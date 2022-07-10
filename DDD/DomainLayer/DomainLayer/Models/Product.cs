using System;
using DomainLayer.Core.Models;
using DomainLayer.DomainLayer.Exceptions;

namespace DomainLayer.DomainLayer.Models
{
    public class Product : Entity
    {
        public  string Name { get; protected set; }
        public string Code { get; protected set; }
        public int Quantity { get; protected set; }
        public decimal Cost { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime ModifiedDate { get; protected set; }
        public bool IsActive { get; protected set; }
        public Product(string name, string code, int quantity, decimal cost)
        {
            if (string.IsNullOrEmpty(name)) throw new CustomDomainException(nameof(name));

            Id = Guid.NewGuid();
            Name = name;
            Code = code;
            Quantity = quantity;
            Cost = cost;
            CreateDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            IsActive = true;
        }
    }
}