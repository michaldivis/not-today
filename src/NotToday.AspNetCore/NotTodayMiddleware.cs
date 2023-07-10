using Microsoft.AspNetCore.Http;
using NotToday.AspNetCore;

namespace NotToday;

public class NotTodayMiddleware
{
    private readonly NotTodayOptions _options;

    public NotTodayMiddleware(RequestDelegate next, NotTodayOptions options)
    {
        _ = next;
        _options = options;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Response.StatusCode = (int)_options.StatusCode;
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync(Responses.GetRandomMessage());
    }
}
