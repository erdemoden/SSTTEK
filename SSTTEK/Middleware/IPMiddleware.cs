using System.Net;

namespace SSTTEK.Middleware;

public class IPMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        var ipAddress = context.Connection.RemoteIpAddress;

        //127.0.0.1 ipV4
        //::1 ipV6

        List<IPAddress> whiteIpList = [IPAddress.Parse("::2")];


        if (whiteIpList.Any(x => x.Equals(ipAddress)))

        {
            await next(context);
        }


        context.Response.StatusCode = 403;
        await context.Response.WriteAsync("Forbidden");
    }
}