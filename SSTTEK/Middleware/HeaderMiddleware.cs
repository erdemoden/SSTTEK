namespace SSTTEK.Middleware;

public class HeaderMiddleware(RequestDelegate next)
{

    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Headers.ContainsKey("Safe"))
        {
            await next.Invoke(context);
        }
        else
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Forbidden");
        }
    }
}