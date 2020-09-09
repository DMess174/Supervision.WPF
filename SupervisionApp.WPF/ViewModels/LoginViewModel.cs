using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Base;
using SupervisionApp.WPF.ViewModels.Messages;
using System.Windows.Input;

namespace SupervisionApp.WPF.ViewModels
{
	public class LoginViewModel : ViewModelBase
	{
		public bool IsBusy { get; set; }

		public string Username { get; set; } = "amburtsevda";

		public string Password { get; set; } = "q2w1e4r3";

		public MessageViewModel ErrorMessageViewModel { get; }

		public string ErrorMessage
		{
			set => ErrorMessageViewModel.Message = value;
		}

		public ICommand LoginCommand { get; }

		public LoginViewModel(IAuthenticator authenticator, IViewModelRenavigator renavigator) : base(authenticator)
		{
			ErrorMessageViewModel = new MessageViewModel(authenticator);
			LoginCommand = new LoginCommand(this, authenticator, renavigator);
		}

		public static LoginViewModel LoadViewModel(IAuthenticator authenticator, 
			IViewModelRenavigator renavigator)
		{
			var vm = new LoginViewModel(authenticator, renavigator);
			return vm;
		}
	}
}
