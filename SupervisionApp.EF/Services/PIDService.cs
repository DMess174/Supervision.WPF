using Supervision.CommonModel.Models.Orders;
using Supervision.CommonModel.Services;
using SupervisionApp.EF.DataContexts.Factories;

namespace SupervisionApp.EF.Services
{
    public class PIDService : DataService<PID>, IPIDService
    {
        public PIDService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
}
