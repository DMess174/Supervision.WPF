using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.EF.DataContexts.Factories;

namespace SupervisionApp.EF.Services
{
    public class PostService : DataService<Post>, IPostService
    {
        public PostService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
}
