using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Core.Models;
using DomainLayer.Core.Repository;
using DomainLayer.Core.Specification;
using InfrastructureLayer.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly DatabaseContext _dbContext;

        protected BaseRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected DatabaseContext GetDbContext() => _dbContext;
        
        public TEntity? FindById(Guid id) => _dbContext.Set<TEntity>().Find(id);

        public IEnumerable<TEntity> Find() => _dbContext.Set<TEntity>().AsEnumerable();

        public TEntity Add(TEntity entity) => _dbContext.Set<TEntity>().Add(entity).Entity;

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity) => _dbContext.Set<TEntity>().Remove(entity);

        public TEntity? FindSingleBySpecification(ISpecification<TEntity> specification) => Find(specification).FirstOrDefault();

        public IEnumerable<TEntity?> Find(ISpecification<TEntity> specification)
        {
            var query = specification.Includes.Aggregate(_dbContext.Set<TEntity>().AsQueryable(),
                (current, include) => current.Include(include));

            var finalQuery = specification.IncludeStrings.Aggregate(query, 
                (current, include) => current.Include(include));

            return finalQuery.Where(specification.Criteria).AsEnumerable();
        }
    }
}