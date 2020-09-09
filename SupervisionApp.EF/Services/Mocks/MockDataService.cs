using SupervisionApp.CommonModel.Services;
using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services.Mocks
{
    public class MockDataService<T> : IDataService<T> where T : BaseEntity
    {
        public IList<T> Items { get; set; }

        private async Task<T> CreateAsync(T entity)
        {
            Items.Add(entity);
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Items.Remove(Items.Where(i => i.Id == id).First());
            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return Items;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return Items.Where(i => i.Id == id).First();
        }

        private async Task<T> UpdateAsync(T entity)
        {
            T item = Items.Where(i => i.Id == entity.Id).First();
            item = entity;
            return item;
        }

        public async Task<T> UpsertAsync(T entity)
        {
            if (Items.Contains(entity))
            {
                UpdateAsync(entity);
            }
            else
            {
                CreateAsync(entity);
            }
            return entity;
        }
    }
}