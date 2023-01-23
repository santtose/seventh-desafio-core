using Microsoft.Extensions.DependencyInjection;
using Seventh.Desafio.Business.Interfaces.Repository;
using Seventh.Desafio.Business.Interfaces.Services;
using Seventh.Desafio.Business.Services;
using Seventh.Desafio.Data.Context;
using Seventh.Desafio.Data.Repository;

namespace Seventh.Desafio.Presentation.Configuration
{
    public static class DepedencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();

            services.AddScoped<IServidorRepository, ServidorRepository>();
            services.AddScoped<IVideoRepository, VideoRepository>();

            services.AddScoped<IServidorService, ServidorService>();
            services.AddScoped<IVideoService, VideoService>();

            return services;
        }
    }
}
