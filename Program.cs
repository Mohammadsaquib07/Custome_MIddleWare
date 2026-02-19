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
public class Program
{  
    public static void Main()
    { 
        IOrderRepository orderRepo = new OrderRepository();
        IOrderService orderserObj = new OrderService(orderRepo);
        var order = orderserObj.CreateOrder(1);
        orderserObj.AddItems(order,"Laptop",35000,3);
        orderserObj.AddItems(order,"Laptop Bag",500,1);

        Console.WriteLine($"Total amount: {orderserObj.GetTotal(order)}");
        Console.WriteLine($"Order Status:{order.Status}");
        //List<Employee> employeeList = Data.GetEmployee();
        //List<Department> deptList = Data.GetDepartment();
        //  var filteredLIst = obj.Filter(x=>x.IsManager == false);
        // foreach(var i in filteredLIst)
        // {
        //     Console.WriteLine($"First Name:{i.FirstName}");
        //     Console.WriteLine($"Last Name:{i.LastName}");
        //     Console.WriteLine($"Annual Salary:{i.AnnualSalary}");
        //     Console.WriteLine($"Is Manager:{i.IsManager}");
        //     Console.WriteLine("----------------");
        // }

        // List<Employee> EmpList = Data.GetEmployee();
        // List<Department> dptList = Data.GetDepartment();
        // var result = EmpList
        // .OrderBy(x=>x.DepartmentId)
        // .ThenByDescending(i=>i.AnnualSalary > 30000)
        // .ThenBy(e=>e.FirstName)
        // .ToList();

        // foreach(var i in result)
        // {
        //     Console.WriteLine($"Employee Id is:{i.DepartmentId}");
        //     Console.WriteLine($"Employee Salary is :{i.AnnualSalary}");
        //     Console.WriteLine($"Employee First Name:{i.FirstName}");
        //     Console.WriteLine("-----------------------");
        //     Console.ReadKey();
        // }
    
//       HashSet<string> Registered = new HashSet<string>(
//         StringComparer.OrdinalIgnoreCase
//       );
// CheckEmail(Registered,"saquibkudle08@gmail.com");
// CheckEmail(Registered,"taufik08@gmail.com");
// CheckEmail(Registered,"saadkudle08@gmail.com");
// CheckEmail(Registered,"Saadkudle08@gmail.com");

    }
    // public static void CheckEmail(HashSet<string> emails,string email)
    // {
    //     if (!emails.Add(email))
    //     {
    //         Console.WriteLine($"Email is already exist {email}");
    //         return;
    //     }
    //     else
    //     {
    //         Console.WriteLine($"Registered email {email}");
    //     }
    // }
}
