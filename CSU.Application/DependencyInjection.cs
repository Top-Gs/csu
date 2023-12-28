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
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IHashtagService, HashtagService>();
            services.AddAutoMapper(typeof(UserProfile));
            services.AddAutoMapper(typeof(NewsProfile));

            return services;
        }
    }
}
