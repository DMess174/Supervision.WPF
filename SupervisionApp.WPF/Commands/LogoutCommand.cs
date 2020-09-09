using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using System;
using System.Windows.Input;

namespace SupervisionApp.WPF.Commands
{
    public class LogoutCommand : ICommand
    {
        private readonly IViewModelRenavigator _renavigator;
        private readonly IAuthenticator _authenticator;

        public LogoutCommand(IAuthenticator authenticator, IViewModelRenavigator renavigator)
        {
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _authenticator.Logout();
            _renavigator.Renavigate();
        }
    }
}
