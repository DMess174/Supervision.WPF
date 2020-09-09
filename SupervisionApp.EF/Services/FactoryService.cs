using Microsoft.EntityFrameworkCore;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services.FactoryService
{
    public class FactoryService : DataService<Factory>, IFactoryService
    {
        private readonly CommonDataContextFactory _contextFactory;

        public FactoryService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Factory>> GetAllIncludeAsync()
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                return await context.Factory
                    .Include(i => i.ProductTypes)
                    .ThenInclude(i => i.ProductType)
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<Factory>> GetEmployeeFactories(Employee employee)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                return await context.Factory
                    .Include(i => i.ProductTypes)
                    .ThenInclude(i => i.ProductType)
                    .Include(i => i.EmployeeFactories)
                    .ThenInclude(i => i.Employee)
                    .Where(i => i.EmployeeFactories.Any(e => e.Employee == employee))
                    .ToListAsync();
            }
        }
    }
}
