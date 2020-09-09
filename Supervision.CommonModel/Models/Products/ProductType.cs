using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.Products
{
    public class ProductType : BaseEntity
    {
        [MaxLength(200)]
        [Required]
        public string FullName { get; set; }

        [MaxLength(50)]
        [Required]
        public string ShortName { get; set; }

        public ICollection<FactoryProductType> Factories { get; set; }
    }
}
