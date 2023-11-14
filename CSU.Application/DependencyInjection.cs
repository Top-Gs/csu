using CSU.Application.Intefaces;
using CSU.Application.Services;

using Microsoft.Extensions.DependencyInjection;

namespace CSU.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<INewsService, NewsService>();

            return services;
        }
    }
}
