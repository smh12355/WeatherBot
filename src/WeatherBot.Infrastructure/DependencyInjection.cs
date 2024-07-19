using Microsoft.Extensions.DependencyInjection;

namespace WeatherBot.Infrastructure;

public static class DependencyInjection
{
    /// <summary>
    /// Di для слоя infrastructure
    /// </summary>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
