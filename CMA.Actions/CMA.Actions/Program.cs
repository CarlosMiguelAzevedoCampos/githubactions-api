var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "Hello Carlos!");
app.MapGet("/carlos", () => "Hello Carlos! ");

app.Run();
