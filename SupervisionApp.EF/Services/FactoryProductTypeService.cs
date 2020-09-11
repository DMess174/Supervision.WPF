using Microsoft.EntityFrameworkCore;
using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services
{
    public class FactoryProductTypeService : DataService<FactoryProductType>, IFactoryProductTypeService
    {
        public FactoryProductTypeService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }

        public async Task<IEnumerable<FactoryProductType>> GetByFactoryIdAsync(int id)
        {
            using(CommonDataContext context = _contextFactory.CreateDbContext())
            {
                var result = await context.FactoryProductTypes
                    .Include(i => i.Factory)
                    .Where(i => i.Factory.Id == id).ToListAsync();
                return result;
            }
        }

        public async Task<IEnumerable<FactoryProductType>> GetByProductTypeIdAsync(int id)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                var result = await context.FactoryProductTypes
                    .Include(i => i.ProductType)
                    .Where(i => i.ProductType.Id == id).ToListAsync();
                return result;
            }
        }
    }
}
