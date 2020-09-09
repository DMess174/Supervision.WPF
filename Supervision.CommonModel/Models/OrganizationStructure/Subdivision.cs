using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.OrganizationStructure
{
    public class Subdivision : BaseEntity
    {
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        public ICollection<SubdivisionDepartment> SubdivisionDepartments { get; set; }
    }
}
