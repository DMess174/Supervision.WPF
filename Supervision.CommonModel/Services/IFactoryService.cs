using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupervisionApp.CommonModel.Services
{
    public interface IFactoryService : IDataService<Factory>
    {
        Task<IEnumerable<Factory>> GetAllIncludeAsync();

        Task<IEnumerable<Factory>> GetEmployeeFactories(Employee employee);
    }
}
