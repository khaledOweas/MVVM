
using MVVMBindings.Delegates;
using MVVMBindings.ViewModels;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVMBindings.ViewModels
{
    public class ViewModel : ViewModelBase
    {

        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand => _changeNameCommand;

        public ViewModel()
        {
            _changeNameCommand = new DelegateCommand(OnChangeName);
        }




        private string _firstName; 
        //public event PropertyChangedEventHandler PropertyChanged;
        public string FirstName { get => _firstName; set => SetProperty(ref _firstName, value); }
        //public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

         


        private void OnChangeName(object commandParameter)
        {
            FirstName = "Walter";
        }
    }
}
