using Microsoft.EntityFrameworkCore;
using Supervision.CommonModel.Models.Orders;
using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.EF.DataContexts.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services
{
    public class SpecificationService : DataService<Specification>, ISpecificationService
    {
        public SpecificationService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }

        public async Task<IEnumerable<Specification>> GetAllByFactoryAsync(Factory factory)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                if (factory != null)
                {
                    var result = await context.Specifications
                        .Include(i => i.PIDs)
                        .ThenInclude(i => i.Factory)
                        .Where(i => i.PIDs.Any(f => f.Factory == factory))
                        .ToListAsync();
                    return result;
                }
                else
                {
                    var result = await context.Specifications
                        .Include(i => i.PIDs)
                        .ThenInclude(i => i.Factory)
                        .ToListAsync();
                    return result;
                }
            }
        }
    }
}
