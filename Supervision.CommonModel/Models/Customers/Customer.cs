using Supervision.CommonModel.Models.Contracts;
using Supervision.CommonModel.Models.Orders;
using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Supervision.CommonModel.Models.Customers
{
    public class Customer : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(20)]
        public string ShortName { get; set; }
        public ICollection<Facility> Facilities { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Specification> Specifications { get; set; }
    }
}