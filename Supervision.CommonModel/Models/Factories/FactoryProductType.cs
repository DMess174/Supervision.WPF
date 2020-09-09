using SupervisionApp.CommonModel.Models.Products;
using SupervisionApp.ModelAPI;

namespace SupervisionApp.CommonModel.Models.Factories
{
    public class FactoryProductType : BaseEntity
    {
        public Factory Factory { get; set; }

        public ProductType ProductType { get; set; }
    }
}
