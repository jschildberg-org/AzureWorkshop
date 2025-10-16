using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace JWS2.Function;

public class HttpTriggerJWS2
{
    private readonly ILogger<HttpTriggerJWS2> _logger;

    public HttpTriggerJWS2(ILogger<HttpTriggerJWS2> logger)
    {
        _logger = logger;
    }

    [Function("HttpTriggerJWS2")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}