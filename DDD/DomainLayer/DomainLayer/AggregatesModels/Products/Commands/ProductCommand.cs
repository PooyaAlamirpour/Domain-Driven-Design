using DomainLayer.Core.Commands;

namespace DomainLayer.DomainLayer.AggregatesModels.Products.Commands
{
    public class ProductCommand : Command
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}