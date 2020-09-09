using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Base;
using SupervisionApp.WPF.ViewModels.Messages;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace SupervisionApp.WPF.ViewModels
{
    public class LoginFactoryViewModel : ViewModelBase
    {
        private readonly IFactoryService _factoryService;

        public bool IsBusy { get; set; }

        public IEnumerable<Factory> Factories { get; set; }

        public Factory Factory { get; set; }

        public MessageViewModel MessageViewModel { get; set; }

        public string Message
        {
            set => MessageViewModel.Message = value;
        }

        public ICommand ViewLoginCommand { get; }

        public ICommand LoginFactoryCommand { get; }

        public LoginFactoryViewModel(IAuthenticator authenticator, IViewModelRenavigator loginRenavigator,
            IViewModelRenavigator entryRenavigator, IFactoryService factoryService) : base(authenticator)
        {
            _factoryService = factoryService;
            MessageViewModel = new MessageViewModel(authenticator);
            LoginFactoryCommand = new LoginFactoryCommand(authenticator, entryRenavigator, this);
            ViewLoginCommand = new LogoutCommand(authenticator, loginRenavigator);
        }

        public static LoginFactoryViewModel LoadViewModel(IAuthenticator authenticator, IViewModelRenavigator loginRenavigator, 
            IViewModelRenavigator entryRenavigator, IFactoryService factoryService)
        {
            var vm = new LoginFactoryViewModel(authenticator, loginRenavigator, entryRenavigator, factoryService);
            vm.LoadData(authenticator);
            return vm;
        }

        private async void LoadData(IAuthenticator authenticator)
        {
            try
            {
                Message = string.Empty;
                IsBusy = true;
                Factories = await _factoryService.GetEmployeeFactories(authenticator.CurrentAccount.Employee);
                if(Factories == null)
                {
                    Message = "Заводы не найдены";
                }
                else
                {
                    Factory = Factories.First();
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
