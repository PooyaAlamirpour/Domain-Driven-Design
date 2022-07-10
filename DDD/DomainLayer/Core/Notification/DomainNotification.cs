using System;
using System.Security.AccessControl;
using DomainLayer.Core.Events;
using MediatR;

namespace DomainLayer.Core.Notification
{
    public class DomainNotification : DomainEvent
    {
        public Guid DomainNotificationId { get; set; }
        public string Value { get; set; }
        public string Key { get; set; }
    }
}