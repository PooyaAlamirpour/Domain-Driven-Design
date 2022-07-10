using System;
using System.Collections.Generic;
using DomainLayer.Core.Events;

namespace DomainLayer.Core.Models
{
    public class Entity
    {
        public Guid Id { get; protected set; }
        private List<DomainEvent> _domainEvents;

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        public List<DomainEvent> DomainEvents => _domainEvents;
        
        public void AddDomainEvent(DomainEvent domainEvent)
        {
            _domainEvents ??= new List<DomainEvent>();
            _domainEvents.Add(domainEvent);
        }
    }
}