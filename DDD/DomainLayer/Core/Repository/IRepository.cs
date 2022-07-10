using System;
using System.Collections.Generic;
using DomainLayer.Core.Models;
using DomainLayer.Core.Specification;

namespace DomainLayer.Core.Repository
{
    public interface IRepository<T> where T : Entity
    {
        T FindById(Guid id);
        IEnumerable<T> Find();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        T FindSingleBySpecification(ISpecification<T> specification);
        IEnumerable<T> Find(ISpecification<T> specification);
    }
}