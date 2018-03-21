using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace SoSmallPDF
{
    /// <summary>
    /// Interaction logic for AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void UpdateUrlButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/soyCracker/SoSmallPDF/releases");
        }
    }
}
