using Microsoft.EntityFrameworkCore;
using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services
{
    public class SubdivisionDepartmentService : DataService<SubdivisionDepartment>, ISubdivisionDepartmentService
    {
        public SubdivisionDepartmentService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }

        public async Task<IEnumerable<SubdivisionDepartment>> GetBySubdivisionIdAsync(int id)
        {
            using(CommonDataContext context = _contextFactory.CreateDbContext())
            {
                var result = await context.SubdivisionDepartments
                    .Include(i => i.Subdivision)
                    .Where(i => i.Subdivision.Id == id).ToListAsync();
                return result;
            }
        }

        public async Task<IEnumerable<SubdivisionDepartment>> GetByDepartmentIdAsync(int id)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                var result = await context.SubdivisionDepartments
                    .Include(i => i.Department)
                    .Where(i => i.Department.Id == id).ToListAsync();
                return result;
            }
        }
    }
}
