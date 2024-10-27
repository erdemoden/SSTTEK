namespace SSTTEK.Middleware;

public class AddHeaderMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        if (!context.Request.Headers.ContainsKey("Safe"))
        {
            context.Request.Headers.Add("Safe", "Safe");
        }
        
        await next(context);
    }
    
}