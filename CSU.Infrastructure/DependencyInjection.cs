using CSU.Application.Common.Interfaces;
using CSU.Infrastructure.Common.Persistence;
using CSU.Infrastructure.Match.Persistance;
using CSU.Infrastructure.Members.Persistence;
using CSU.Infrastructure.News.Persistence;
using CSU.Infrastructure.Sponsors.Persistence;
using CSU.Infrastructure.Users.Persistance;

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
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<ISponsorsRepository, SponsorsRepository>();
            services.AddScoped<IMatchRepository, MatchRepository>();
            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<CsuDbContext>());

            return services;
        }
    }
}
