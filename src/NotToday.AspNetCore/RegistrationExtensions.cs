using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace NotToday;

public static class RegistrationExtensions
{
    public static IServiceCollection AddNotToday(this IServiceCollection services, Action<NotTodayOptions>? configurator = null)
    {
        var options = new NotTodayOptions();
        configurator?.Invoke(options);
        services.AddSingleton(options ?? new());
        return services;
    }

    public static IApplicationBuilder UseNotToday(this IApplicationBuilder app)
    {
        app.UseMiddleware<NotTodayMiddleware>();
        return app;
    }
}
