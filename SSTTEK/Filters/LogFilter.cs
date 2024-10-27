using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SSTTEK.Filters;

public class LogFilter(ILogger<LogFilter> logger) : IActionFilter
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    
    public void OnActionExecuting(ActionExecutingContext context)
    {
        stopwatch = Stopwatch.StartNew();
        var actionName = context.ActionDescriptor.DisplayName;
        logger.LogInformation($"Action '{actionName}' başladı at {DateTime.UtcNow}.");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        stopwatch.Stop();
        var actionName = context.ActionDescriptor.DisplayName;
        var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        logger.LogInformation($"Action '{actionName}' bitti at {DateTime.UtcNow}. İşlem süresi: {elapsedMilliseconds} ms.");
    }
}