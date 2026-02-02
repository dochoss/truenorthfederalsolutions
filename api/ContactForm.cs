using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Azure;
using Azure.Communication.Email;

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

public class ContactForm(CosmosClient cosmosClient, EmailClient emailClient, ILogger<ContactForm> logger)
{
  private const string DatabaseName = "truenorth";
  private const string ContainerName = "contact-form";
  private const string SenderAddress = "DoNotReply@truenorthfederalsolutions.com";
  private const string NotificationRecipient = "info@truenorthfederalsolutions.com";

  [Function("ContactForm")]
  public async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "contact")] HttpRequest req)
  {
    logger.LogInformation("Processing contact form submission");

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
        return new BadRequestObjectResult(new { error = "Invalid request body" });
      }

      // Validate required fields
      if (string.IsNullOrWhiteSpace(contactRequest.FirstName) ||
          string.IsNullOrWhiteSpace(contactRequest.LastName) ||
          string.IsNullOrWhiteSpace(contactRequest.Email) ||
          string.IsNullOrWhiteSpace(contactRequest.Company) ||
          string.IsNullOrWhiteSpace(contactRequest.Interest))
      {
        logger.LogWarning("Missing required fields in contact form");
        return new BadRequestObjectResult(new { error = "Missing required fields" });
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

      // Send email notification
      await SendEmailNotificationAsync(document);

      logger.LogInformation("Email notification sent for contact form. Id: {Id}", document.Id);

      return new OkObjectResult(new
      {
        success = true,
        message = "Thank you for your submission. We will be in touch soon."
      });
    }
    catch (CosmosException ex)
    {
      logger.LogError(ex, "Cosmos DB error: {StatusCode} - {Message}", ex.StatusCode, ex.Message);
      return new ObjectResult(new { error = "Failed to save contact form" })
      {
        StatusCode = (int)HttpStatusCode.InternalServerError
      };
    }
    catch (JsonException ex)
    {
      logger.LogWarning(ex, "JSON parsing error");
      return new BadRequestObjectResult(new { error = "Invalid JSON format" });
    }
    catch (Exception ex)
    {
      logger.LogError(ex, "Unexpected error processing contact form");
      return new ObjectResult(new { error = "An unexpected error occurred" })
      {
        StatusCode = (int)HttpStatusCode.InternalServerError
      };
    }
  }

  private async Task SendEmailNotificationAsync(ContactFormDocument document)
  {
    var subject = $"New Contact Form Submission from {document.FirstName} {document.LastName}";
    var htmlContent = $@"
      <html>
        <body>
          <h2>New Contact Form Submission</h2>
          <table style='border-collapse: collapse; width: 100%; max-width: 600px;'>
            <tr><td style='padding: 8px; border: 1px solid #ddd;'><strong>Name</strong></td><td style='padding: 8px; border: 1px solid #ddd;'>{document.FirstName} {document.LastName}</td></tr>
            <tr><td style='padding: 8px; border: 1px solid #ddd;'><strong>Email</strong></td><td style='padding: 8px; border: 1px solid #ddd;'>{document.Email}</td></tr>
            <tr><td style='padding: 8px; border: 1px solid #ddd;'><strong>Company</strong></td><td style='padding: 8px; border: 1px solid #ddd;'>{document.Company}</td></tr>
            <tr><td style='padding: 8px; border: 1px solid #ddd;'><strong>Phone</strong></td><td style='padding: 8px; border: 1px solid #ddd;'>{document.Phone ?? "N/A"}</td></tr>
            <tr><td style='padding: 8px; border: 1px solid #ddd;'><strong>Interest</strong></td><td style='padding: 8px; border: 1px solid #ddd;'>{document.Interest}</td></tr>
            <tr><td style='padding: 8px; border: 1px solid #ddd;'><strong>Message</strong></td><td style='padding: 8px; border: 1px solid #ddd;'>{document.Message ?? "N/A"}</td></tr>
          </table>
          <p style='margin-top: 16px; color: #666;'>Submitted at: {document.SubmittedAt:yyyy-MM-dd HH:mm:ss} UTC</p>
          <p style='color: #666;'>Submission ID: {document.Id}</p>
        </body>
      </html>";

    var plainTextContent = $@"
New Contact Form Submission

Name: {document.FirstName} {document.LastName}
Email: {document.Email}
Company: {document.Company}
Phone: {document.Phone ?? "N/A"}
Interest: {document.Interest}
Message: {document.Message ?? "N/A"}

Submitted at: {document.SubmittedAt:yyyy-MM-dd HH:mm:ss} UTC
Submission ID: {document.Id}";

    var emailMessage = new EmailMessage(
      senderAddress: SenderAddress,
      content: new EmailContent(subject)
      {
        PlainText = plainTextContent,
        Html = htmlContent
      },
      recipients: new EmailRecipients(
      [
        new(NotificationRecipient)
      ]));

    // Use WaitUntil.Started to return immediately after the email is queued
    // rather than waiting for full delivery (which can take 10+ seconds)
    await emailClient.SendAsync(WaitUntil.Started, emailMessage);
  }
}