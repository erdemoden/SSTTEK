using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SSTTEK.Extensions;

public static class LogFilterExt
{
    public static void logFilterExt<T>(this WebApplicationBuilder builder) where T : class, IActionFilter
    {
        builder.Services.AddScoped<T>();
        builder.Services.AddControllersWithViews(options =>
        {
            options.Filters.Add<T>();
        });
    }
}