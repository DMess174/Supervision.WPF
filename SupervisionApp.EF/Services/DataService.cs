using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using SupervisionApp.ModelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services
{
    public abstract class DataService<T> : IDataService<T> where T : BaseEntity
    {
        protected readonly CommonDataContextFactory _contextFactory;

        public DataService(CommonDataContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                return await context.Set<T>().ToListAsync();
            }
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                return await context.Set<T>().SingleOrDefaultAsync(a => a.Id == id);
            }
        }

        

        public async Task<bool> DeleteAsync(int id)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }

        //public async Task<T> GetSomeItem(Expression<Func<T, bool>> predicate)
        //{
        //    using (CommonDataContext context = _contextFactory.CreateDbContext())
        //    {
        //        T entity = await context.Set<T>().FirstOrDefaultAsync(predicate);
        //        return entity;
        //    }
        //}

        public async Task<T> UpsertAsync(T entity)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                if (context.Entry(entity).State == EntityState.Added)
                {
                    await CreateAsync(entity);
                }
                else
                {
                    await UpdateAsync(entity);
                }
                return entity;
            }
        }

        private async Task<T> CreateAsync(T entity)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return createdResult.Entity;
            }
        }

        private async Task<T> UpdateAsync(T entity)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                context.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();

                return entity;
            }
        }

 
    }
}