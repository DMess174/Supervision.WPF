using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.EF.DataContexts.Factories;

namespace SupervisionApp.EF.Services
{
    public class SubdivisionService : DataService<Subdivision>, ISubdivisionService
    {
        public SubdivisionService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
}
