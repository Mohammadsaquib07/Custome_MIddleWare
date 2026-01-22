public class CustomeMiddleware{
    private readonly RequestDelegate _next;
    public CustomeMiddleware(RequestDelegate next){
        _next = next;
    }
    public async Task Invoke(HttpContext context){
        Console.WriteLine($"request dikha bhai {context.Request.Method} {context.Request.Path}");
        await _next(context);
        Console.WriteLine($"response dikha bhai {context.Response.StatusCode}");
    }
}