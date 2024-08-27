using MiddlewaresTutorial.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<CustomMiddleware>();

var app = builder.Build();

// Middleware 1
app.UseMiddleware<CustomMiddleware>();

// Middleware 2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello from the second middleware!\n");
    await next(context);
});

app.Run();
