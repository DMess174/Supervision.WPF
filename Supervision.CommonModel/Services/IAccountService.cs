using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupervisionApp.CommonModel.Services
{
    public interface IAccountService : IDataService<Account>
    {
        Task<Account> GetByUsernameAsync(string username);

        Task<IEnumerable<Account>> GetAllIncludeAsync();

        Task<Account> GetByIdIncludeAsync(int id);
    }
}
