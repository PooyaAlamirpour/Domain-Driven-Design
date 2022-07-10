using System;
using System.Collections.Generic;
using DomainLayer.Core.Models;
using DomainLayer.Core.Repository;
using DomainLayer.Core.Specification;

namespace InfrastructureLayer.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public TEntity FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find()
        {
            throw new NotImplementedException();
        }

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity FindSingleBySpecification(ISpecification<TEntity> specification)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(ISpecification<TEntity> specification)
        {
            throw new NotImplementedException();
        }
    }
}