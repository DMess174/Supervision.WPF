using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupervisionApp.CommonModel.Services
{
    public interface IEmployeeService : IDataService<Employee>
    {
        Task<IEnumerable<Employee>> GetAllIncludeAsync();

        IEnumerable<Employee> GetAllInclude();
    }
}
