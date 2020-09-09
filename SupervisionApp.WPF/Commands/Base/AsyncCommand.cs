using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupervisionApp.WPF.Commands.Base
{
    public abstract class AsyncCommand : CommandBase
    {
        private bool _isExecuting;
        public bool IsExecuting
        {
            get
            {
                return _isExecuting;
            }
            set
            {
                _isExecuting = value;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }

        public new event EventHandler CanExecuteChanged;

        public override bool CanExecute(object parameter)
        {
            return !IsExecuting;
        }

        public override async void Execute(object parameter)
        {
            IsExecuting = true;

            await ExecuteAsync(parameter);

            IsExecuting = false;
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
