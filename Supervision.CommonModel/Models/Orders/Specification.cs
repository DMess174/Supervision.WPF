using Supervision.CommonModel.Enums;
using Supervision.CommonModel.Models.Customers;
using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Supervision.CommonModel.Models.Orders
{
    public class Specification : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Number { get; set; }

        [Required]
        public Customer Customer { get; set; }
        public Facility Facility { get; set; }
        public SpecificationProgrammes Programme { get; set; }
        public SpecificationStatus Status { get; set; }
        public ICollection<PID> PIDs { get; set; }
    }
}
