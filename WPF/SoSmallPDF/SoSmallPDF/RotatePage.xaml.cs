using iTextSharp.text.pdf;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace SoSmallPDF
{
    /// <summary>
    /// Interaction logic for RotatePage.xaml
    /// </summary>
    public partial class RotatePage : Page
    {
        string inputPdf;
        SelectFileClass sfc = new SelectFileClass();

        public RotatePage()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            inputPdf = sfc.selectFile();
            SelectFileTextBlock.Text = inputPdf;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(inputPdf))
            {
                if (DegreeComboBox.SelectedIndex >= 0 && DegreeComboBox.SelectedIndex <= 2)
                {
                    string outputPdf = sfc.saveFile();
                    if (!string.IsNullOrEmpty(outputPdf))
                    {
                        rotateWholePdf(inputPdf, (DegreeComboBox.SelectedIndex + 1) * 90, outputPdf);
                    }
                    MessageTextBlock.Text = "請選擇旋轉角度：";
                }
                else
                {
                    MessageTextBlock.Text = "你沒選擇轉幾度！！！！！！";
                }
            }
            else
            {
                MessageTextBlock.Text = "你沒選擇檔案！！！！！！！";
            }
            

            //SelectFileTextBlock.Text = DegreeComboBox.SelectedIndex.ToString();
        }

        public void rotateWholePdf(string inputPdf,int degree ,string outputPdf)
        {
            using (PdfReader reader = new PdfReader(inputPdf))
            {
                int pagesCount = reader.NumberOfPages;
                for (int n = 1; n <= pagesCount; n++)
                {
                    PdfDictionary page = reader.GetPageN(n);
                    PdfNumber rotate = page.GetAsNumber(PdfName.ROTATE);
                    int rotation =
                            rotate == null ? degree : (rotate.IntValue + degree) % 360;

                    page.Put(PdfName.ROTATE, new PdfNumber(rotation));
                }
                using (PdfStamper stamper = new PdfStamper(reader, File.Create(outputPdf)))
                {
                    stamper.Close();
                    reader.Close();
                }
            }
        }
    }
}
