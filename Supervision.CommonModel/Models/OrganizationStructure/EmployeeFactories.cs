using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.ModelAPI;

namespace SupervisionApp.CommonModel.Models.OrganizationStructure
{
    public class EmployeeFactories : BaseEntity
    {
        public Employee Employee { get; set; }

        public Factory Factory { get; set; }
    }
}
