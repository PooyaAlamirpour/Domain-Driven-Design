using FluentValidation.Results;
using MediatR;

namespace DomainLayer.Core.Commands
{
    public abstract class Command : IRequest<bool>
    {
        public ValidationResult InlineValidationResult { get; set; }
        public abstract bool IsValid();
    }
}