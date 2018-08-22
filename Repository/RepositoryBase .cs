using Contracts;
using Entities;
using Entities.Models;
using Entities.ViewModels;
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
        protected EIA_DEVContext_View EIA_DEVContext_View { get; set; }

        public RepositoryBase(EIA_DEVContext eia_devContext)
        {
            this.EIA_DEVContext = eia_devContext;
        }

        public RepositoryBase(EIA_DEVContext_View eia_devContext_view)
        {
            this.EIA_DEVContext_View = eia_devContext_view;
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

        public async Task<IEnumerable<T>> FindAllAsyncView()
        {
            return await this.EIA_DEVContext_View.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAyncView(Expression<Func<T, bool>> expression)
        {
            return await this.EIA_DEVContext_View.Set<T>().Where(expression).ToListAsync();
        }
    }
}
