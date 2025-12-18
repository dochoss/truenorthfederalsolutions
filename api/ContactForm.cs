using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace TrueNorthFederalSolutions.Api;

public record ContactFormRequest(
  string FirstName,
  string LastName,
  string Email,
  string Company,
  string? Phone,
  string Interest,
  string? Message
);

public record ContactFormDocument(
  [property: JsonPropertyName("id")] string Id,
  [property: JsonPropertyName("firstName")] string FirstName,
  [property: JsonPropertyName("lastName")] string LastName,
  [property: JsonPropertyName("email")] string Email,
  [property: JsonPropertyName("company")] string Company,
  [property: JsonPropertyName("phone")] string? Phone,
  [property: JsonPropertyName("interest")] string Interest,
  [property: JsonPropertyName("message")] string? Message,
  [property: JsonPropertyName("submittedAt")] DateTime SubmittedAt
);

public class ContactFormOutput
{
  [ServiceBusOutput("contact-form", Connection = "ServiceBusConnection")]
  public string? ServiceBusMessage { get; set; }

  [HttpResult]
  public IActionResult? HttpResponse { get; set; }
}

public class ContactForm(CosmosClient cosmosClient, ILogger<ContactForm> logger)
{
  private const string DatabaseName = "truenorth";
  private const string ContainerName = "contact-form";

  [Function("ContactForm")]
  public async Task<ContactFormOutput> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "contact")] HttpRequest req)
  {
    logger.LogInformation("Processing contact form submission");
    var output = new ContactFormOutput();

    try
    {
      // Deserialize the request body
      var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
      var options = new JsonSerializerOptions
      {
        PropertyNameCaseInsensitive = true
      };
      var contactRequest = JsonSerializer.Deserialize<ContactFormRequest>(requestBody, options);

      if (contactRequest is null)
      {
        logger.LogWarning("Invalid request body received");
        output.HttpResponse = new BadRequestObjectResult(new { error = "Invalid request body" });
        return output;
      }

      // Validate required fields
      if (string.IsNullOrWhiteSpace(contactRequest.FirstName) ||
          string.IsNullOrWhiteSpace(contactRequest.LastName) ||
          string.IsNullOrWhiteSpace(contactRequest.Email) ||
          string.IsNullOrWhiteSpace(contactRequest.Company) ||
          string.IsNullOrWhiteSpace(contactRequest.Interest))
      {
        logger.LogWarning("Missing required fields in contact form");
        output.HttpResponse = new BadRequestObjectResult(new { error = "Missing required fields" });
        return output;
      }

      // Create document for Cosmos DB
      var document = new ContactFormDocument(
        Id: Guid.NewGuid().ToString(),
        FirstName: contactRequest.FirstName,
        LastName: contactRequest.LastName,
        Email: contactRequest.Email,
        Company: contactRequest.Company,
        Phone: contactRequest.Phone,
        Interest: contactRequest.Interest,
        Message: contactRequest.Message,
        SubmittedAt: DateTime.UtcNow
      );

      // Get or create database and container
      var database = cosmosClient.GetDatabase(DatabaseName);
      var container = database.GetContainer(ContainerName);

      // Insert into Cosmos DB
      var response = await container.CreateItemAsync(
        document,
        new PartitionKey(document.Id)
      );

      logger.LogInformation(
        "Contact form saved successfully. Id: {Id}, Email: {Email}, RU: {RequestCharge}",
        document.Id,
        document.Email,
        response.RequestCharge
      );

      // Send the document to Service Bus queue for further processing
      var messageJson = JsonSerializer.Serialize(document);
      output.ServiceBusMessage = messageJson;
      output.HttpResponse = new OkObjectResult(new
      {
        success = true,
        message = "Thank you for your submission. We will be in touch soon."
      });

      logger.LogInformation("Contact form message sent to Service Bus queue. Id: {Id}", document.Id);

      return output;
    }
    catch (CosmosException ex)
    {
      logger.LogError(ex, "Cosmos DB error: {StatusCode} - {Message}", ex.StatusCode, ex.Message);
      output.HttpResponse = new ObjectResult(new { error = "Failed to save contact form" })
      {
        StatusCode = (int)HttpStatusCode.InternalServerError
      };
      return output;
    }
    catch (JsonException ex)
    {
      logger.LogWarning(ex, "JSON parsing error");
      output.HttpResponse = new BadRequestObjectResult(new { error = "Invalid JSON format" });
      return output;
    }
    catch (Exception ex)
    {
      logger.LogError(ex, "Unexpected error processing contact form");
      output.HttpResponse = new ObjectResult(new { error = "An unexpected error occurred" })
      {
        StatusCode = (int)HttpStatusCode.InternalServerError
      };
      return output;
    }
  }
}