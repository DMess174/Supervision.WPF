using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.ViewModels.Base;

namespace SupervisionApp.WPF.ViewModels.Messages
{
    public class MessageViewModel : ViewModelBase
    {
        private string _message;

        public MessageViewModel(IAuthenticator authenticator) : base(authenticator)
        {
        }

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
                OnPropertyChanged(nameof(HasMessage));
            }
        }

        public bool HasMessage => !string.IsNullOrEmpty(Message);
    }
}
