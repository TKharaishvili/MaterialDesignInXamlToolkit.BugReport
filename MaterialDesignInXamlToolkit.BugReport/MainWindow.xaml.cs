using MaterialDesignThemes.Wpf;
using System.Windows;

namespace MaterialDesignInXamlToolkit.BugReport
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await DialogHost.Show(new MessageBox(), "TheIdentifier");
        }
    }
}
