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
        string inputPdf;
        SelectFileClass sfc = new SelectFileClass();

        public MergePage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            string outputPdf = sfc.saveFile();
            string[] pdfList = new string[PdfListBox.Items.Count];
            for(int i=0;i< PdfListBox.Items.Count;i++)
            {
                StackPanel stack = (StackPanel)PdfListBox.Items[i];
                TextBlock text = (TextBlock)stack.Children[0];
                pdfList[i] = text.Text;
            }
            mergeTwoPdf(pdfList, outputPdf);
            MessageTextBlock.Text = "完成！";
            inputPdf = "";
            PdfListBox.Items.Clear();
        }

        //合併PDF
        public void mergeTwoPdf(string[] inputPdf, string outputPdf)
        {
            Document document = new Document();
            PdfCopy copy = new PdfCopy(document, new FileStream(outputPdf, FileMode.Create));
            document.Open();
            foreach(string p in inputPdf)
            {
                if (!string.IsNullOrEmpty(p))
                {
                    PdfReader reader = new PdfReader(p);
                    copy.AddDocument(reader);
                    reader.Close();
                }
            }
            copy.Close();
            document.Close();
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            inputPdf = sfc.selectFile();
            MessageTextBlock.Text = "可拖曳檔案至上方框，按順序選擇檔案:";
            setupPdfListBox(inputPdf);
        }

        //移除list中的pdf
        private void RemoveFileButton_Click(object sender, RoutedEventArgs e)
        {
            PdfListBox.Items.Remove(PdfListBox.SelectedItem);
        }

        //上移pdf
        private void UpFileButton_Click(object sender, RoutedEventArgs e)
        {
            if(PdfListBox.SelectedIndex>0)
            {
                var temp = PdfListBox.SelectedItem;
                int tempIndex = PdfListBox.SelectedIndex;
                PdfListBox.Items.RemoveAt(tempIndex);
                PdfListBox.Items.Insert(tempIndex - 1, temp);
                PdfListBox.SelectedIndex = tempIndex - 1;
            }
        }

        //下移pdf
        private void DownFileButton_Click(object sender, RoutedEventArgs e)
        {
            if (0 <= PdfListBox.SelectedIndex && PdfListBox.SelectedIndex + 1 < PdfListBox.Items.Count)
            {
                var temp = PdfListBox.SelectedItem;
                int tempIndex = PdfListBox.SelectedIndex;
                PdfListBox.Items.RemoveAt(tempIndex);
                PdfListBox.Items.Insert(tempIndex + 1, temp);
                PdfListBox.SelectedIndex = tempIndex + 1;
            }
        }

        public void setupPdfListBox(string inputPdf)
        {
            StackPanel stk = new StackPanel();
            stk.Name = "stack";
            stk.Orientation = Orientation.Horizontal;
            stk.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlock text = new TextBlock();
            text.Name = "text";
            text.Text = inputPdf;
            text.FontSize = 12;
            text.VerticalAlignment = VerticalAlignment.Center;

            stk.Children.Add(text);
            PdfListBox.Items.Add(stk);
        }

        //拖曳檔案進listbox
        private void PdfListBox_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                string[] temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                inputPdf = temp[0];
                MessageTextBlock.Text = "可拖曳檔案至上方框，按順序選擇檔案:";
                if(Path.GetExtension(inputPdf).ToLower()==".pdf")
                {
                    setupPdfListBox(inputPdf);
                }
                else
                {
                    MessageTextBlock.Text = "這不是PDF";
                }
            }
        }
    }
}
