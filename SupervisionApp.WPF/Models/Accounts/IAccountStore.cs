using SupervisionApp.CommonModel.Enums;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System;

namespace SupervisionApp.WPF.Models.Accounts
{
    public interface IAccountStore
    {
        Account CurrentAccount { get; set; }

        UserRoles CurrentRole { get; }

        Factory CurrentFactory { get; set; }

        bool IsLoggedIn { get; }

        event Action StateChanged;
    }
}
