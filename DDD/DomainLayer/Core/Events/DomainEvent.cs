using System;
using MediatR;

namespace DomainLayer.Core.Events
{
    public class DomainEvent : INotification
    {
        public DateTime Created { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}