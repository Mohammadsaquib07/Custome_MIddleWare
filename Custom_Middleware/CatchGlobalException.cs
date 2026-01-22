using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

public class CatchGlobalException{

    private readonly RequestDelegate _next;

    private readonly ILogger<CatchGlobalException> _logger;


    public CatchGlobalException(RequestDelegate next,ILogger<CatchGlobalException> logger){
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context){
        try{
            await _next(context);
        }
        catch(Exception Ex){
            _logger.LogError(Ex,"Unhandled exception occured");
            context.Response.StatusCode = (int)(HttpStatusCode.InternalServerError);
            context.Response.ContentType = "application/json";

            var response = new {
                message = "Something went wrong. PLease try again later",
                traceId = context.TraceIdentifier
            };

            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response)
            );
        }
    }
}