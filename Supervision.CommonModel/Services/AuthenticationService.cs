using Microsoft.AspNetCore.Identity;
using SupervisionApp.CommonModel.Exceptions;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System.Threading.Tasks;

namespace SupervisionApp.CommonModel.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAccountService _accountService;
        private readonly IPasswordHasher<Account> _passwordHasher;

        public AuthenticationService(IAccountService accountService, IPasswordHasher<Account> passwordHasher)
        {
            _accountService = accountService;
            _passwordHasher = passwordHasher;
        }

        public async Task<Account> LoginAsync(string username, string password)
        {
            Account storedAccount = await _accountService.GetByUsernameAsync(username);

            if (storedAccount == null)
            {
                throw new UserNotFoundException(username);
            }

            PasswordVerificationResult passwordResult = _passwordHasher.VerifyHashedPassword(storedAccount, storedAccount.PasswordHash, password);

            if (passwordResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(username, password);
            }

            return storedAccount;
        }

        public async Task<RegistrationResult> RegisterAsync(string email, string username, string password, string confirmPassword, Employee employee)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                result = RegistrationResult.PasswordsDoNotMatch;

                return result;
            }

            Account usernameAccount = await _accountService.GetByUsernameAsync(username);

            if (usernameAccount != null)
            {
                result = RegistrationResult.UsernameAlreadyExists;
             
                return result;
            }

            if (result == RegistrationResult.Success)
            {

                Account account = new Account()
                {
                    Username = username,

                    Employee = employee
                };

                account.PasswordHash = _passwordHasher.HashPassword(account, password);

                await _accountService.UpsertAsync(account);
            }

            return result;
        }
    }
}
