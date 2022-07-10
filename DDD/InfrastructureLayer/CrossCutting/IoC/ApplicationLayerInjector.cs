using ApplicationLayer.MappingConfigurations;
using ApplicationLayer.Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace InfrastructureLayer.CrossCutting.IoC
{
    public class ApplicationLayerInjector
    {
        public static void Use(IServiceCollection services)
        {
            services.AddScoped<IMapper>(sp => AutoMapping.RegisterMappings().CreateMapper());
            
            services.AddScoped<IProductService, ProductService>();
        }
    }
}