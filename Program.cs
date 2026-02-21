using userInfo;
using System;
using System.Diagnostics;
using System.Linq;  
using Microsoft.EntityFrameworkCore;
// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseSqlServer(
//         builder.Configuration.GetConnectionString("Sql_Connection_String")));

// builder.Services.AddControllers();

// builder.Services.AddScoped<IPaymentService, PaymentService>();
// builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();

// var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild",
//     "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast = Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();

//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

// app.MapControllers();

// // middleware order matters
// // app.UseMiddleware<CustomeMiddleware>();
// // app.UseMiddleware<MonitorRequestTime>();
// // app.UseMiddleware<CatchGlobalException>();
// // app.UseMiddleware<JwtAuthMiddleware>();

// // app.Run(context =>
// // {
// //     throw new Exception("Boom");
// // });
// app.Run();
// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }

// using System.Security.Cryptography.X509Certificates;
// using Microsoft.AspNetCore.Mvc.ModelBinding;

using OrderServiceInterface;
using OrderServiceImplementation;
using domain.orderentity;
using IOrderRepositoryInterface;
using OrderRepositoryImplementation;
using PercentageDiscountStrategyImplementation;
public class Program
{  
    public static void Main()
    { 
        IOrderRepository orderRepo = new OrderRepository();
        IOrderService orderserObj = new OrderService(orderRepo);
        var discountStrategy = new PercentageDiscountStrategy(50);
        var order = orderserObj.CreateOrder(1);
        orderserObj.AddItems(order,"Laptop",35000,3);
        orderserObj.AddItems(order,"Laptop Bag",500,1);
        var originalTotal = order.GetRawTotalAmount();
        var discountedTotal = orderserObj.GetTotal(order, discountStrategy);
        var discountApplied = orderserObj.GetDiscountApplied(order, discountStrategy);
        Console.WriteLine($"Original Total: {originalTotal}");
        Console.WriteLine($"Discounted Total: {discountedTotal}");
        Console.WriteLine($"Discount Applied: {discountApplied}");
        Console.WriteLine($"Order Status:{order.Status}");
    }
}
