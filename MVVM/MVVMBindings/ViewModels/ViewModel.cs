
using MVVMBindings.Delegates;
using System.Windows.Input;

namespace MVVMBindings.ViewModels
{
    public class ViewModel : ViewModelBase
    {

        private readonly DelegateCommand _changeNameCommand;
        public new ICommand ChangeNameCommand => _changeNameCommand;
        string _name;

        public ViewModel(string name)
        {
            _changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
            _name = name;
        }
        private string _firstName;
        //public event PropertyChangedEventHandler PropertyChanged;
        public string FirstName { get => _firstName; set => SetProperty(ref _firstName, value); }
        //public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void OnChangeName(object commandParameter)
        {
            FirstName = _name;
            _changeNameCommand.InvokeCanExecuteChanged();
        }

        private bool CanChangeName(object commandParameter)
        {
            return FirstName != _name;
        }
    }
}
