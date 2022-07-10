using DomainLayer.Core.Commands;
using DomainLayer.Core.Notification;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace InfrastructureLayer.CrossCutting.IoC
{
    public class DomainLayerInjector
    {
        public static void Use(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<ICommandDispatcher, CommandDispatcher>();
            
            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
        }
    }
}