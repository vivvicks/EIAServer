using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected EIA_DEVContext EIA_DEVContext { get; set; }

        public RepositoryBase(EIA_DEVContext eia_devContext)
        {
            this.EIA_DEVContext = eia_devContext;
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this.EIA_DEVContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression)
        {
            return await this.EIA_DEVContext.Set<T>().Where(expression).ToListAsync();
        }

        public void Create(T entity)
        {
            this.EIA_DEVContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.EIA_DEVContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.EIA_DEVContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await this.EIA_DEVContext.SaveChangesAsync();
        }    
    }
}
