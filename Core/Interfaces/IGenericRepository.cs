using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {//BaseEntity: Here we are constraining it by saying GR can be used only by classes derived from BaseEntity
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();

        //Now these methods we are creating which will take specification (includes) as parameter
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}