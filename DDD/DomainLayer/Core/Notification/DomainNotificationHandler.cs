using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using DomainLayer.Core.Events;

namespace DomainLayer.Core.Notification
{
    public class DomainNotificationHandler : IEventHandler<DomainNotification>
    {
        private readonly List<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }

        public ReadOnlyCollection<DomainNotification> Notifications => _notifications.AsReadOnly();
        
        public Task Handle(DomainNotification notification, CancellationToken cancellationToken)
        {
            _notifications.Add(notification);
            return Task.CompletedTask;
        }

        public bool HasNotification() => Notifications.Count <= 0;
    }
}