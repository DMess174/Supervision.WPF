using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.ModelAPI;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.OrganizationStructure
{
    public class SubdivisionDepartment : BaseEntity
    {
        [Required]
        public Department Department { get; set; }

        [Required]
        public Subdivision Subdivision { get; set; }

        public ObservableCollection<Employee> Employees { get; set; }

        public ObservableCollection<Factory> Factories { get; set; }

        public override string ToString() => $"{Department?.ShortName}\n{Subdivision?.Name}";
    }
}
