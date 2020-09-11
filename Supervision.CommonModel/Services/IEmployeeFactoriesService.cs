using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supervision.CommonModel.Services
{
    public interface IEmployeeFactoriesService : IDataService<EmployeeFactories>
    {
        Task<IEnumerable<EmployeeFactories>> GetByEmployeeIdAsync(int id);

        Task<IEnumerable<EmployeeFactories>> GetByFactoryIdAsync(int id);
    }
}
