
namespace MiddlewaresTutorial.Middlewares
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from the first middleware!\n");

            await next(context);

            await context.Response.WriteAsync("Hello from the first middleware again!\n");
        }
    }
}
