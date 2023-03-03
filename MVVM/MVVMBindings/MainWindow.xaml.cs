using MVVMBindings.ViewModels;
using System.Windows;

namespace MVVMBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            var viewModel = new ViewModel();
            viewModel.FirstName = " Khaled ";
            DataContext = viewModel;

            InitializeComponent();

            viewModel.FirstName = " Changed Name ";
            
            //viewModel.OnPropertyChanged(nameof(ViewModel.FirstName));

        }
    }
}
