using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.Products;
using SupervisionApp.EF.DataContexts.Factories;

namespace SupervisionApp.EF.Services
{
    public class ProductTypeService : DataService<ProductType>, IProductTypeService
    {
        public ProductTypeService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
}
