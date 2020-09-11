using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SupervisionApp.CommonModel.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> UpsertAsync(T entity);

        Task<bool> DeleteAsync(int id);

        //Task<T> GetSomeItem(Expression<Func<T, bool>> predicate);
    }
}
