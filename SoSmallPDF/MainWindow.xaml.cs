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

        //拖曳視窗
        public void DragWindow(object sender, MouseButtonEventArgs args)
        {
            this.DragMove();
        }

        //為了實現無邊框視窗必須另外建一個關閉按鈕來關閉程式
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
