using SupervisionApp.CommonModel.Exceptions;
using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels;
using System;
using System.Threading.Tasks;

namespace SupervisionApp.WPF.Commands
{
    public class LoginCommand : AsyncCommand
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly IViewModelRenavigator _renavigator;
        private readonly IAuthenticator _authenticator;

        public LoginCommand(LoginViewModel loginViewModel, IAuthenticator authenticator, IViewModelRenavigator renavigator)
        {
            _loginViewModel = loginViewModel;
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _loginViewModel.ErrorMessage = string.Empty;

            try
            {
                await _authenticator.Login(_loginViewModel.Username, _loginViewModel.Password);

                _renavigator.Renavigate();
            }
            catch (UserNotFoundException)
            {
                _loginViewModel.ErrorMessage = "Пользователь не найден";
            }
            catch (InvalidPasswordException)
            {
                _loginViewModel.ErrorMessage = "Неверный пароль.";
            }
            catch (Exception)
            {
                _loginViewModel.ErrorMessage = "Ошибка входа.";
            }
        }
    }
}
