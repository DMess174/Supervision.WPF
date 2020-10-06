using Supervision.CommonModel.Models.Orders;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supervision.CommonModel.Services
{
    public interface ISpecificationService : IDataService<Specification>
    {
        Task<IEnumerable<Specification>> GetAllByFactoryAsync(Factory factory);
    }
}
