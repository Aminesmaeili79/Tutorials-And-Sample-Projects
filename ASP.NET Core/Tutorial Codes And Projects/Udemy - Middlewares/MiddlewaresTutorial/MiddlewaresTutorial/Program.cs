var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello from the first middleware!\n");
    await next(context);
});

// Middleware 2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello from the second middleware!\n");
    await next(context);
});

app.Run();
