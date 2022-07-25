using Messenger.ViewModels;
using System.Windows;

namespace Messenger.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await ((MainWindowViewModel)this.DataContext).InitViewModel();
        }

    }
}
