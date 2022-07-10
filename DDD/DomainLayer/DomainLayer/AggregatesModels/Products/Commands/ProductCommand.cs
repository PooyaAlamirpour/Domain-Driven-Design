using DomainLayer.Core.Commands;
using DomainLayer.DomainLayer.AggregatesModels.Products.Validations;

namespace DomainLayer.DomainLayer.AggregatesModels.Products.Commands
{
    public abstract class ProductCommand : Command
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}