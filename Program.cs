using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ ALL SERVICE REGISTRATION MUST BE HERE
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Sql_Connection_String")));

builder.Services.AddControllers();

builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();

// 🔒 BUILD ONLY AFTER SERVICES ARE REGISTERED
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild",
    "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();

    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapControllers();

// middleware order matters
// app.UseMiddleware<CustomeMiddleware>();
// app.UseMiddleware<MonitorRequestTime>();
// app.UseMiddleware<CatchGlobalException>();
// app.UseMiddleware<JwtAuthMiddleware>();

// app.Run(context =>
// {
//     throw new Exception("Boom");
// });
app.Run();
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

// using System.Security.Cryptography.X509Certificates;
// using Microsoft.AspNetCore.Mvc.ModelBinding;

// public class Program
// {
//     static int sendAmount = 100;
//     public void AddBonus(ref int bonusAmount)
//     {
//         bonusAmount+=1000;

//     }

//     public static void Main()
//     {
//         Program obj = new Program();
//          obj.AddBonus(ref sendAmount);
//         Console.WriteLine(sendAmount);
//         //List<Employee> employeeList = Data.GetEmployee();
//         //List<Department> deptList = Data.GetDepartment();
//         //  var filteredLIst = obj.Filter(x=>x.IsManager == false);
//         // foreach(var i in filteredLIst)
//         // {
//         //     Console.WriteLine($"First Name:{i.FirstName}");
//         //     Console.WriteLine($"Last Name:{i.LastName}");
//         //     Console.WriteLine($"Annual Salary:{i.AnnualSalary}");
//         //     Console.WriteLine($"Is Manager:{i.IsManager}");
//         //     Console.WriteLine("----------------");
//         // }

//         // List<Employee> EmpList = Data.GetEmployee();
//         // List<Department> dptList = Data.GetDepartment();
//         // var result = EmpList
//         // .OrderBy(x=>x.DepartmentId)
//         // .ThenByDescending(i=>i.AnnualSalary > 30000)
//         // .ThenBy(e=>e.FirstName)
//         // .ToList();

//         // foreach(var i in result)
//         // {
//         //     Console.WriteLine($"Employee Id is:{i.DepartmentId}");
//         //     Console.WriteLine($"Employee Salary is :{i.AnnualSalary}");
//         //     Console.WriteLine($"Employee First Name:{i.FirstName}");
//         //     Console.WriteLine("-----------------------");
//         //     Console.ReadKey();
//         // }

//     }
// }
