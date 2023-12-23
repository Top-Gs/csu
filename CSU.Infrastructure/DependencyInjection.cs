using CSU.Application.Common.Interfaces;
using CSU.Infrastructure.Common.Persistence;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CSU.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<CsuDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost;Database=CSUSuceava; Trusted_Connection=true;TrustServerCertificate=true;");
            });
            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<CsuDbContext>());

            return services;
        }
    }
}
