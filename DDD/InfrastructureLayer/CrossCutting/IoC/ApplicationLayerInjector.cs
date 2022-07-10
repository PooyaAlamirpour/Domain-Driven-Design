using ApplicationLayer.Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace InfrastructureLayer.CrossCutting.IoC
{
    public class ApplicationLayerInjector
    {
        public static void Use(IServiceCollection services)
        {
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            
            services.AddScoped<IProductService, ProductService>();
        }
    }
}