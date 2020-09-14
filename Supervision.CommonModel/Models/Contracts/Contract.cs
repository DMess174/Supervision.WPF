using Supervision.CommonModel.Models.Customers;
using SupervisionApp.ModelAPI;
using System;
using System.ComponentModel.DataAnnotations;

namespace Supervision.CommonModel.Models.Contracts
{
    public class Contract : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Number { get; set; }

        public DateTime SignDate { get; set; }

        public bool IsInForce { get; set; }

        [Required]
        public Customer Customer { get; set; }
    }
}