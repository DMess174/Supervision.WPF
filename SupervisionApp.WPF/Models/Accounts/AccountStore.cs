using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System;

namespace SupervisionApp.WPF.Models.Accounts
{
    public class AccountStore : IAccountStore
    {
        private Account _currentAccount;
        
        public Account CurrentAccount
        {
            get
            {
                return _currentAccount;
            }
            set
            {
                _currentAccount = value;
                StateChanged?.Invoke();
            }
        }

        private Factory _currentFactory;

        public Factory CurrentFactory
        {
            get
            {
                return _currentFactory;
            }
            set
            {
                _currentFactory = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}
