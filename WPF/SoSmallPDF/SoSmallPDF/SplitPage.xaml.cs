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
            MessageTextBlock.Text = "2. 請輸入要保留的頁碼\n比如：1,4-6,9";
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            inputPdf = sfc.selectFile();
            SelectFileTextBlock.Text = inputPdf;
            MessageTextBlock.Text = "2. 請輸入要保留的頁碼\n比如：1,4-6,9";
        }

        //留下所選擇的頁碼，以達到分割的效果
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
            //檢查是否有選擇檔案
            if(!string.IsNullOrEmpty(inputPdf))
            {
                //檢查是否有輸入頁碼
                if (!string.IsNullOrEmpty(SelectPageTextBox.Text))
                {
                    string outputPdf = sfc.saveFile();
                    if(!string.IsNullOrEmpty(outputPdf))
                    {
                        SelectPages(inputPdf, SelectPageTextBox.Text, outputPdf);
                    }
                    MessageTextBlock.Text = "完成！";
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

        //拖曳檔案進textblock
        private void SelectFileTextBlock_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                string[] temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                inputPdf = temp[0];
                MessageTextBlock.Text = "2. 請輸入要保留的頁碼\n比如：1,4-6,9";
                if (Path.GetExtension(inputPdf).ToLower() == ".pdf")
                {
                    SelectFileTextBlock.Text = inputPdf;
                }
                else
                {
                    MessageTextBlock.Text = "這不是PDF";
                }
            }
        }
    }
}
