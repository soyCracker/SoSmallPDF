using System.Windows;

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

        /*private void splitButton_Click(object sender, RoutedEventArgs e)
        {
            SplitWindow splitWindow = new SplitWindow();
            splitWindow.Show();
            this.Close();
            
        }*/

        /*private void mergeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rotateButton_Click(object sender, RoutedEventArgs e)
        {

        }*/
    }
}
