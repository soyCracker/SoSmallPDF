using System.Windows;
using System.Windows.Input;

namespace SoSmallPDF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.Navigate(new MainPage());
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new MainPage());
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new AboutPage());
        }

        public void DragWindow(object sender, MouseButtonEventArgs args)
        {
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
