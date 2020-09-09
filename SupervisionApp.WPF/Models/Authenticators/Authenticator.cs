using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Models.Accounts;
using System;
using System.Threading.Tasks;

namespace SupervisionApp.WPF.Models.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IAccountStore _accountStore;

        public Authenticator(IAuthenticationService authenticationService, IAccountStore accountStore)
        {
            _authenticationService = authenticationService;
            _accountStore = accountStore;
        }

        public Account CurrentAccount
        {
            get
            {
                return _accountStore.CurrentAccount;
            }
            private set
            {
                _accountStore.CurrentAccount = value;
                StateChanged?.Invoke();
            }
        }

        public Factory CurrentFactory
        {
            get
            {
                return _accountStore.CurrentFactory;
            }
            private set
            {
                _accountStore.CurrentFactory = value;
                StateChanged?.Invoke();
            }
        }

        public bool IsLoggedIn => CurrentAccount != null;

        public event Action StateChanged;

        public async Task Login(string username, string password)
        {
            CurrentAccount = await _authenticationService.LoginAsync(username, password);
        }

        public void LoginFactory(Factory factory)
        {
            CurrentFactory = factory;
        }

        public void Logout()
        {
            CurrentAccount = null;
            CurrentFactory = null;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword, Employee employee)
        {
            return await _authenticationService.RegisterAsync(email, username, password, confirmPassword, employee);
        }
    }
}
