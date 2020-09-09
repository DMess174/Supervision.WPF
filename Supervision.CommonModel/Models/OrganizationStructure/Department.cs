using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.OrganizationStructure
{
    public class Department : BaseEntity
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string ShortName { get; set; }

        public ICollection<SubdivisionDepartment> SubdivisionDepartments { get; set; }
    }
}
