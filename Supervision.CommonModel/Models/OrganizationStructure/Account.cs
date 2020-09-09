using SupervisionApp.CommonModel.Enums;
using SupervisionApp.ModelAPI;
using System.ComponentModel.DataAnnotations;

namespace SupervisionApp.CommonModel.Models.OrganizationStructure
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public UserRoles Role { get; set; }

        public Employee Employee { get; set; }
    }
}
