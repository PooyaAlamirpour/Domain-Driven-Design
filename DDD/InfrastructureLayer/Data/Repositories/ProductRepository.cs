using System.Linq;
using DomainLayer.DomainLayer.AggregatesModels.Products.Repository;
using DomainLayer.DomainLayer.Models;
using InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
            
        }

        public Product? FindByName(string name) =>
            GetDbContext().Products.AsNoTracking().FirstOrDefault(x => x.Name.Equals(name)) ?? null;
    }
}