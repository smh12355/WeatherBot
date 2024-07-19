using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using MediatR;

namespace WeatherBot.Application;

public static class DependencyInjection
{
    /// <summary>
    /// Di для слоя application
    /// </summary>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

        return services;
    }
}
