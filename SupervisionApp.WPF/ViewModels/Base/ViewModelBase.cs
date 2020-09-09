using SupervisionApp.WPF.Models;
using SupervisionApp.WPF.Models.Authenticators;

namespace SupervisionApp.WPF.ViewModels.Base
{
    public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : ViewModelBase;

    public abstract class ViewModelBase : ObservableObject
    {
        public IAuthenticator Authenticator;

        //public UserRoles CurrentRole { get => Authenticator.CurrentAccount.Role; }

        public ViewModelBase(IAuthenticator authenticator)
        {
            Authenticator = authenticator;
        }
    }
}
