using Dinner.Application.Common.Interfaces;
using Dinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Dinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}