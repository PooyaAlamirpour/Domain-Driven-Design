using DomainLayer.DomainLayer.AggregatesModels.Products.Commands;
using FluentValidation;

namespace DomainLayer.DomainLayer.AggregatesModels.Products.Validations
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(product => product.Name).NotEmpty().WithMessage("The product name is mandatory");
            RuleFor(product => product.Quantity).LessThanOrEqualTo(0).WithMessage("The product quantity must be greater than 0");
            RuleFor(product => product.Code).NotEmpty().WithMessage("The product code must not be empty");
        }
    }
}