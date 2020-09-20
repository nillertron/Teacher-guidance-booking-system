using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Command
{
    public class CommandRepository<T> : ICommandRepository<T> where T : BaseEntity
    {
        protected readonly VejledningsContext context;
        protected readonly DbSet<T> table;
        public CommandRepository(VejledningsContext context)
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


    }
}
