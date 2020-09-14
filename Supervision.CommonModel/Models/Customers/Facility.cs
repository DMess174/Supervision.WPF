using Supervision.CommonModel.Models.Orders;
using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Supervision.CommonModel.Models.Customers
{
    public class Facility : BaseEntity
    {
        [Required]
        [MaxLength(4000)]
        public string Name { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public ICollection<Specification> Specifications { get; set; }
    }
}
