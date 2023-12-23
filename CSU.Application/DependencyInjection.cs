using CSU.Application.Interfaces;
using CSU.Application.Mapping;
using CSU.Application.Services;

using Microsoft.Extensions.DependencyInjection;

namespace CSU.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddAutoMapper(typeof(UserProfile));

            return services;
        }
    }
}
