using Microsoft.Extensions.DependencyInjection;
using Sample.Application.Services.Authentication.Commands;
using Sample.Application.Services.Authentication.Queries;

namespace Sample.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();
        services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();

        return services;
    }
}