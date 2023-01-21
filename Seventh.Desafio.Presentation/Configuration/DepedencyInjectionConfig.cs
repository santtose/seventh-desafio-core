using Microsoft.Extensions.DependencyInjection;
using Seventh.Desafio.Data.Context;

namespace Seventh.Desafio.Presentation.Configuration
{
    public static class DepedencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();

            return services;
        }
    }
}
