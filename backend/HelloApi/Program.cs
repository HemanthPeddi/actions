var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", () =>
{
    return "Hello from .NET API. We have to learn .NET";
});

app.Run();