using CSU.Application.Comman.Interfaces;
using CSU.Infrastructure.Comman.Persistence;
using CSU.Infrastructure.Repositories;

using Microsoft.Extensions.DependencyInjection;

namespace CSU.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<INewsRepository, NewsRepository>();

            return services;
        }

    }
}
