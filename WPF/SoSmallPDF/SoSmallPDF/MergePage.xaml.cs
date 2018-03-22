using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace SoSmallPDF
{
    /// <summary>
    /// Interaction logic for MergePage.xaml
    /// </summary>
    public partial class MergePage : Page
    {
        string[] inputPdf = new string[5];
        SelectFileClass sfc = new SelectFileClass();

        public MergePage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            int fileCount = 0;
            for(int i=0;i<5;i++)
            {
                if (!string.IsNullOrEmpty(inputPdf[i]))
                {
                    fileCount++;
                }
            }
            if(fileCount>1)
            {
                string outputPdf = sfc.saveFile();
                mergeTwoPdf(inputPdf, outputPdf);
                MessageTextBlock.Text = "按順序選擇檔案，最多5個：";
            }
            else
            {
                MessageTextBlock.Text = "至少選擇2個檔案！！！！！！！";
            }
        }

        public void mergeTwoPdf(string[] inputPdf, string outputPdf)
        {
            Document document = new Document();
            PdfCopy copy = new PdfCopy(document, new FileStream(outputPdf, FileMode.Create));
            document.Open();
            for(int i=0;i<5;i++)
            {
                if(!string.IsNullOrEmpty(inputPdf[i]))
                {
                    PdfReader reader = new PdfReader(inputPdf[i]);
                    copy.AddDocument(reader);
                    reader.Close();
                }
            }
            copy.Close();
            document.Close();
        }

        private void SelectFileButton1_Click(object sender, RoutedEventArgs e)
        {
            inputPdf[0] = sfc.selectFile();
            SelectFileTextBlock1.Text = inputPdf[0];
        }

        private void SelectFileButton2_Click(object sender, RoutedEventArgs e)
        {
            inputPdf[1] = sfc.selectFile();
            SelectFileTextBlock2.Text = inputPdf[1];
        }

        private void SelectFileButton3_Click(object sender, RoutedEventArgs e)
        {
            inputPdf[2] = sfc.selectFile();
            SelectFileTextBlock3.Text = inputPdf[2];
        }

        private void SelectFileButton4_Click(object sender, RoutedEventArgs e)
        {
            inputPdf[3] = sfc.selectFile();
            SelectFileTextBlock4.Text = inputPdf[3];
        }

        private void SelectFileButton5_Click(object sender, RoutedEventArgs e)
        {
            inputPdf[4] = sfc.selectFile();
            SelectFileTextBlock5.Text = inputPdf[4];
        }
    }
}
