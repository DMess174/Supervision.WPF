using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;

namespace SupervisionApp.WPF.Commands
{
    public class LoginFactoryCommand : CommandBase
    {
        private readonly IViewModelRenavigator _renavigator;
        private readonly IAuthenticator _authenticator;

        public LoginFactoryCommand(IAuthenticator authenticator, IViewModelRenavigator renavigator)
        {
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override bool CanExecute(object parameter) => parameter is Factory;

        public override void Execute(object parameter)
        {
            _authenticator.LoginFactory(parameter as Factory);
            _renavigator.Renavigate();
        }
    }
}
