using System;
using System.Windows.Input;

namespace MVVMBindings.Delegates
{
    public class DelegateCommand : ICommand
    {

        private readonly Action<object> _executeAction;
        private readonly Func<object, bool> _canExecuteAction;

        public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter)
        {
            return _canExecuteAction.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
        public void InvokeCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
