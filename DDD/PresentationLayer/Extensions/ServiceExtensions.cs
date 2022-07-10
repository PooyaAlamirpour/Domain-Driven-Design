using InfrastructureLayer.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationLayer.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterAllRequiredServices(this IServiceCollection services)
        {
            ApplicationLayerInjector.Use(services);
            DomainLayerInjector.Use(services);
            InfrastructureLayerInjector.Use(services);
        }
    }
}