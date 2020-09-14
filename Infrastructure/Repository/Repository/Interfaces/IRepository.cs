using Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Delete(T entity);
        Task<List<T>> GetAll(params Expression<Func<T, object>>[] includes);
        Task<T> GetSingle(int id, params Expression<Func<T, object>>[] includes);
        Task Update(T entity);
    }
}