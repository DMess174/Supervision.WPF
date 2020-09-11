using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervision.CommonModel.Services
{
    public interface ISubdivisionDepartmentService : IDataService<SubdivisionDepartment>
    {
        Task<IEnumerable<SubdivisionDepartment>> GetBySubdivisionIdAsync(int id);

        Task<IEnumerable<SubdivisionDepartment>> GetByDepartmentIdAsync(int id);
    }
}
