using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Exceptions;
using System;
using System.Threading.Tasks;
using SupervisionApp.CommonModel.Services;

namespace SupervisionApp.WPF.Models.Authenticators
{
    public interface IAuthenticator
    {
        Account CurrentAccount { get; }
        Factory CurrentFactory { get; }

        event Action StateChanged;

        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword, Employee employee);

        /// <summary>
        /// Login to the application.
        /// </summary>
        /// <param name="username">The user's name.</param>
        /// <param name="password">The user's password.</param>
        /// <exception cref="UserNotFoundException">Thrown if the user does not exist.</exception>
        /// <exception cref="InvalidPasswordException">Thrown if the password is invalid.</exception>
        /// <exception cref="Exception">Thrown if the login fails.</exception>
        Task Login(string username, string password);

        void LoginFactory(Factory factory);
        
        void Logout();
    }
}
