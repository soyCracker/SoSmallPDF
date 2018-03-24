using System;
using System.Windows;
using System.Windows.Controls;

namespace SoSmallPDF
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void splitButton_Click(object sender, RoutedEventArgs e)
        {
            //切換頁面
            this.NavigationService.Navigate(new Uri("SplitPage.xaml", UriKind.Relative));
        }

        private void mergeButton_Click(object sender, RoutedEventArgs e)
        {
            //切換頁面
            this.NavigationService.Navigate(new Uri("MergePage.xaml", UriKind.Relative));
        }

        private void rotateButton_Click(object sender, RoutedEventArgs e)
        {
            //切換頁面
            this.NavigationService.Navigate(new Uri("RotatePage.xaml", UriKind.Relative));
        }
    }
}
