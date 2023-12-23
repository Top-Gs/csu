using Microsoft.Extensions.DependencyInjection;

namespace CSU.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
