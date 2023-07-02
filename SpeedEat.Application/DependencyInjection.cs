using Microsoft.Extensions.DependencyInjection;
using SpeedEat.Application.Services.Authentication;

namespace SpeedEat.Application;

public static class DependencyInjection {
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}