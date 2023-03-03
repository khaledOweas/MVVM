
using MVVMBindings.ViewModels;
using System.ComponentModel;

namespace MVVMBindings.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel() : base()
        {
        }
        private string _firstName;

        //public event PropertyChangedEventHandler PropertyChanged;
        public string FirstName { get => _firstName; set => SetProperty(ref _firstName, value); }
        //public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
