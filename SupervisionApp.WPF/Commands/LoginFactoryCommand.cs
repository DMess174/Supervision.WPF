using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace SupervisionApp.WPF.Commands
{
    public class LoginFactoryCommand : ICommand
    {
        private readonly LoginFactoryViewModel _loginFactoryViewModel;
        private readonly IViewModelRenavigator _renavigator;
        private readonly IAuthenticator _authenticator;

        public LoginFactoryCommand(IAuthenticator authenticator, IViewModelRenavigator renavigator, LoginFactoryViewModel loginFactoryViewModel)
        {
            _authenticator = authenticator;
            _renavigator = renavigator;
            _loginFactoryViewModel = loginFactoryViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
                _authenticator.LoginFactory(_loginFactoryViewModel.Factory);
                _renavigator.Renavigate();
        }
    }
}
