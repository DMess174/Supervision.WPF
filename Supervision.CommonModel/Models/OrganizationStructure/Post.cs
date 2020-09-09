using SupervisionApp.ModelAPI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.OrganizationStructure
{
    public class Post : BaseEntity
    {
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
