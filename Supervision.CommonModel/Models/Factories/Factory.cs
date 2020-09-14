using Supervision.CommonModel.Models.Orders;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.Factories
{
    /// <summary>
    /// Завод-изготовитель продукции
    /// </summary>
    public class Factory : BaseEntity
    {
        [MaxLength(200)]
        [Required]
        public string FullName { get; set; }

        [MaxLength(50)]
        [Required]
        public string ShortName { get; set; }

        [MaxLength(200)]
        [Required]
        public string City { get; set; }

        [Required]
        public SubdivisionDepartment SubdivisionDepartment { get; set; }
        public ICollection<FactoryProductType> ProductTypes { get; set; }
        public ICollection<EmployeeFactories> EmployeeFactories { get; set; }
        public ICollection<PID> PIDs { get; set; }
    }
}
