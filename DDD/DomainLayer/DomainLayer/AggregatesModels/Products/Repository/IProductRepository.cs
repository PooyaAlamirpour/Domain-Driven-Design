using DomainLayer.Core.Repository;
using DomainLayer.DomainLayer.Models;

namespace DomainLayer.DomainLayer.AggregatesModels.Products.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product FindByName(Product product);
    }
}