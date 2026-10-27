using MyApp.Core;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Calculators calc=new Calculators();

app.MapGet("/", () => "MyApp API is running");

app.MapGet("/add", (int a, int b) => new { a, b, result = calc.Add(a, b) });

app.MapGet("/subtract", (int a, int b) => new { a, b, result = calc.Subtract(a, b) });


app.Run();
