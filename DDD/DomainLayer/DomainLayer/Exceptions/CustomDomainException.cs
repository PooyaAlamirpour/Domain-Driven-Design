using System;

namespace DomainLayer.DomainLayer.Exceptions
{
    public class CustomDomainException : Exception
    {
        public CustomDomainException(string message) : base(message) { }
    }
}