using Microsoft.AspNetCore.Http;
using System.Diagnostics;

public class MonitorRequestTime{

    private readonly RequestDelegate _next;
    
    public MonitorRequestTime(RequestDelegate next){
        _next = next;
    }

    public async Task Invoke(HttpContext context){
        var stopwatch = Stopwatch.StartNew();

        await _next(context);

        stopwatch.Stop();

        Console.WriteLine($"time dikha bhai kitna lera hai..{context.Request.Method} {context.Request.Path} took {stopwatch.ElapsedMilliseconds} ms");
    }
}