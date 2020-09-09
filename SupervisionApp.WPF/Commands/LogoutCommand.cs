using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;

namespace SupervisionApp.WPF.Commands
{
    public class LogoutCommand : CommandBase
    {
        private readonly IViewModelRenavigator _renavigator;
        private readonly IAuthenticator _authenticator;

        public LogoutCommand(IAuthenticator authenticator, IViewModelRenavigator renavigator)
        {
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _authenticator.Logout();
            _renavigator.Renavigate();
        }
    }
}
