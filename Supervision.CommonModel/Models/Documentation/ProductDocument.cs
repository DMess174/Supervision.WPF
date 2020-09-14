using SupervisionApp.CommonModel.Models.Products;
using System.Collections.Generic;

namespace Supervision.CommonModel.Models.Documentation
{
    /// <summary>
    /// НТД на изделие
    /// </summary>
    public class ProductDocument : TechnicalDocument
    {
        public ICollection<ProductType> ProductTypes { get; set; }
    }
}
