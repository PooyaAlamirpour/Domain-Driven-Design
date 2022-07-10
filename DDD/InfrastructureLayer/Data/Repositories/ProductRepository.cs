using System;
using DomainLayer.DomainLayer.AggregatesModels.Products.Repository;
using DomainLayer.DomainLayer.Models;

namespace InfrastructureLayer.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public Product FindByName(Product product)
        {
            throw new NotImplementedException();
        }
    }
}