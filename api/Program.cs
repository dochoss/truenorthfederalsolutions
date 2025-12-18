using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Hosting;
using Azure.Communication.Email;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights();

builder.Services.AddSingleton<CosmosClient>(sp =>
{
    var connectionString = Environment.GetEnvironmentVariable("CosmosDBConnectionString");
    return new CosmosClient(connectionString, new CosmosClientOptions
    {
        SerializerOptions = new CosmosSerializationOptions
        {
            PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase
        }
    });
});

builder.Services.AddSingleton<EmailClient>(sp =>
{
    var connectionString = Environment.GetEnvironmentVariable("AcsConnectionString");
    return new EmailClient(connectionString);
});

builder.Build().Run();
