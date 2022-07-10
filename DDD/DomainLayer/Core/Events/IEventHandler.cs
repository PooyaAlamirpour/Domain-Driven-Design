using MediatR;

namespace DomainLayer.Core.Events
{
    public interface IEventHandler<in TDomainEvent> : INotificationHandler<TDomainEvent> where TDomainEvent : DomainEvent
    {
        
    }
}