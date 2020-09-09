using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System;

namespace SupervisionApp.WPF.Models.Accounts
{
    public interface IAccountStore
    {
        Account CurrentAccount { get; set; }

        Factory CurrentFactory { get; set; }

        event Action StateChanged;
    }
}
