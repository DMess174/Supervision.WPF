using SupervisionApp.WPF.ViewModels.Base;

namespace SupervisionApp.WPF.ViewModels.Messages
{
    public class MessageViewModel : ViewModelBase
    {
        private string _message;

        public MessageViewModel()
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
