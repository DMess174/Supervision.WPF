using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.EF.DataContexts.Factories;

namespace SupervisionApp.EF.Services
{
    public class DepartmentService : DataService<Department>, IDepartmentService
    {
        public DepartmentService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
}
