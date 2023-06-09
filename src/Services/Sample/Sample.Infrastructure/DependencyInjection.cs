using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sample.Application.Common.Interfaces.Authentication;
using Sample.Application.Common.Interfaces.Persistence;
using Sample.Application.Common.Interfaces.Services;
using Sample.Infrastructure.Authentication;
using Sample.Infrastructure.Persistence;
using Sample.Infrastructure.Services;

namespace Sample.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}