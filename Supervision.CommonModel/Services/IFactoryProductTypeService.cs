using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supervision.CommonModel.Services
{
    public interface IFactoryProductTypeService : IDataService<FactoryProductType>
    {
        Task<IEnumerable<FactoryProductType>> GetByFactoryIdAsync(int id);

        Task<IEnumerable<FactoryProductType>> GetByProductTypeIdAsync(int id);
    }
}
