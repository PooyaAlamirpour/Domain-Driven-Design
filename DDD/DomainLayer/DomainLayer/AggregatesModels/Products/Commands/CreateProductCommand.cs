using DomainLayer.DomainLayer.AggregatesModels.Products.Validations;

namespace DomainLayer.DomainLayer.AggregatesModels.Products.Commands
{
    public sealed class CreateProductCommand : ProductCommand
    {
        public CreateProductCommand(string name, string code, int quantity, decimal cost)
        {
            Name = name;
            Code = code;
            Quantity = quantity;
            Cost = cost;
        }
        
        public override bool IsValid()
        {
            InlineValidationResult = new CreateProductCommandValidator().Validate(this);
            return InlineValidationResult.IsValid;
        }
    }
}