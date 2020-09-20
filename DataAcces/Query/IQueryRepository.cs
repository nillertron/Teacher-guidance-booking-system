using Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAcces.Query
{
    public interface IQueryRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll(params Expression<Func<T, object>>[] includes);
        Task<T> GetSingle(int id, params Expression<Func<T, object>>[] includes);
    }
}