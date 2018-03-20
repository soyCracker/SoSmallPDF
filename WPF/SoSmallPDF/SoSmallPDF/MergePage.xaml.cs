using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoSmallPDF
{
    /// <summary>
    /// Interaction logic for MergePage.xaml
    /// </summary>
    public partial class MergePage : Page
    {
        string inputPdf1, inputPdf2;
        SelectFileClass sfc = new SelectFileClass();

        public MergePage()
        {
            InitializeComponent();
        }

        private void SelectFileButton1_Click(object sender, RoutedEventArgs e)
        {
            inputPdf1 = sfc.selectFile();
            SelectFileTextBlock1.Text = inputPdf1;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(inputPdf1)&& !string.IsNullOrEmpty(inputPdf2))
            {
                string outputPdf = sfc.saveFile();
                if (!string.IsNullOrEmpty(outputPdf))
                {
                    mergeTwoPdf(inputPdf1, inputPdf2, outputPdf);
                }
                MessageTextBlock.Text = "請選擇2個檔案：";
            }
            else
            {
                MessageTextBlock.Text = "你沒選擇檔案！！！！！！！";
            }
        }

        private void SelectFileButton2_Click(object sender, RoutedEventArgs e)
        {
            inputPdf2 = sfc.selectFile();
            SelectFileTextBlock2.Text = inputPdf2;
        }

        public void mergeTwoPdf(string inputPdf1, string inputPdf2, string outputPdf)
        {
            PdfReader reader1 = new PdfReader(inputPdf1);
            PdfReader reader2 = new PdfReader(inputPdf2);
            Document document = new Document();
            PdfCopy copy = new PdfCopy(document, new FileStream(outputPdf, FileMode.Create));
            document.Open();
            copy.AddDocument(reader1);
            copy.AddDocument(reader2);
            document.Close();
            reader1.Close();
            reader2.Close();
        }
    }
}
