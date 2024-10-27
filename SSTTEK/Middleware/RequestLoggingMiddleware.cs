using System.Diagnostics;

namespace SSTTEK.Middleware;

public class RequestLoggingMiddleware(ILogger<RequestLoggingMiddleware> logger, RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        var request = context.Request;
        var method = request.Method;
        var url = $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";

        var stopwatch = Stopwatch.StartNew();
        
        await next(context);
        
        stopwatch.Stop();
        var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

        var logMessage = $"HTTP {method} {url} responded {context.Response.StatusCode} in {elapsedMilliseconds} ms";
        
        logger.LogInformation(logMessage);
    }
}