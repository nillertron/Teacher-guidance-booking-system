using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly VejledningsContext context;
        protected readonly DbSet<T> table;
        public Repository(VejledningsContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }
        public async Task Create(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }
        public virtual async Task Update(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
        public virtual async Task Delete(T entity)
        {
            context.Remove(entity);
            await context.SaveChangesAsync();
        }
        public async Task<T> GetSingle(int id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query;
            query = table.Where(x => x.Id == id);
            foreach (var inc in includes)
            {
                query.Include(inc);
            }

            return await query.FirstOrDefaultAsync();
        }
        public async Task<List<T>> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query;
            query = table;
            if(includes != null)
            {
                foreach (var inc in includes)
                {
                    query.Include(inc);
                }
            }

            var list = await query.ToListAsync();
            return list;
        }
    }
}
