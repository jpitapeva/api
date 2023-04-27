using MyApp.Domain.Interfaces.Services;
using MyApp.Infrastructure.Services;

namespace MyApp.Infrastructure;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IHelloWorldService, HelloWorldService>();
        return services;
    }
}