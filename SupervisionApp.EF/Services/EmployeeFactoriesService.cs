using Microsoft.EntityFrameworkCore;
using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services
{
    public class EmployeeFactoriesService : DataService<EmployeeFactories>, IEmployeeFactoriesService
    {
        public EmployeeFactoriesService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }

        public async Task<IEnumerable<EmployeeFactories>> GetByEmployeeIdAsync(int id)
        {
            using(CommonDataContext context = _contextFactory.CreateDbContext())
            {
                var result = await context.EmployeeFactories
                    .Include(i => i.Employee)
                    .Where(i => i.Employee.Id == id).ToListAsync();
                return result;
            }
        }

        public async Task<IEnumerable<EmployeeFactories>> GetByFactoryIdAsync(int id)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                var result = await context.EmployeeFactories
                    .Include(i => i.Factory)
                    .Where(i => i.Factory.Id == id).ToListAsync();
                return result;
            }
        }
    }
}
