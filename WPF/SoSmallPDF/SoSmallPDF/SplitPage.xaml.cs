using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace SoSmallPDF
{
    /// <summary>
    /// Interaction logic for SplitPage.xaml
    /// </summary>
    public partial class SplitPage : Page
    {
        string inputPdf;
        SelectFileClass sfc = new SelectFileClass();

        public SplitPage()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            inputPdf = sfc.selectFile();
            SelectFileTextBlock.Text = inputPdf;
        }

        public void SelectPages(string inputPdf, string pageSelection, string outputPdf)
        {
            PdfReader reader = new PdfReader(inputPdf);
            reader.SelectPages(pageSelection);
            PdfStamper stamper = new PdfStamper(reader, File.Create(outputPdf));
            stamper.Close();
            reader.Close();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(inputPdf))
            {
                if (!String.IsNullOrEmpty(SelectPageTextBox.Text))
                {
                    string outputPdf = sfc.saveFile();
                    if(!string.IsNullOrEmpty(outputPdf))
                    {
                        SelectPages(inputPdf, SelectPageTextBox.Text, outputPdf);
                    }
                    MessageTextBlock.Text = "請輸入要保留的頁碼";
                }
                else
                {
                    MessageTextBlock.Text = "你沒輸入頁碼!!!!!!!!!!!!!!!!!";
                }
            }
            else
            {
                MessageTextBlock.Text = "你沒選擇檔案！！！！！！！";
            }
        }
    }
}
