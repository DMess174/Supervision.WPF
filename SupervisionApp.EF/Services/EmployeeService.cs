using Microsoft.EntityFrameworkCore;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services
{
    public class EmployeeService : DataService<Employee>, IEmployeeService
    {
        public EmployeeService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }

        public override async Task<Employee> GetByIdAsync(int id)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                Employee result = await context.Employees
                    .Include(a => a.Department)
                    .ThenInclude(a => a.Department)
                    .Include(a => a.Department)
                    .ThenInclude(a => a.Subdivision)
                    .Include(a => a.Post)
                    .SingleOrDefaultAsync(a => a.Id == id);
                return result;
            }
        }

        public async Task<IEnumerable<Employee>> GetAllIncludeAsync()
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                return await context.Employees
                    .Include(a => a.Post)
                    .ToListAsync();
            }
        }

        public IEnumerable<Employee> GetAllInclude()
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                var result = context.Employees
                    .Include(a => a.Post)
                    .Include(a => a.Department)
                    .ThenInclude(a => a.Department)
                    .Include(a => a.Department)
                    .ThenInclude(a => a.Subdivision)
                    .OrderBy(a => a.LastName)
                    .ThenBy(a => a.FirstName)
                    .ThenBy(a => a.Patronymic)
                    .ToList();
                return result;
            }
        }
    }
}
