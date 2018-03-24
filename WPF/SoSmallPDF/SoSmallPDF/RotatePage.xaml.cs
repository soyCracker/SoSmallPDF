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
            //清空ListBox
            PageListBox.Items.Clear();
            inputPdf = sfc.selectFile();
            SelectFileTextBlock.Text = inputPdf;
            if(!string.IsNullOrEmpty(inputPdf))
            {
                PdfReader reader = new PdfReader(inputPdf);
                setupListBox(reader.NumberOfPages);
                reader.Close();
            }
            MessageTextBlock.Text = "請選擇旋轉角度：";
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            string outputPdf = sfc.saveFile();
            rotateSomePage(inputPdf, outputPdf);
            MessageTextBlock.Text = "完成！";
        }

        //指定個各別頁面旋轉角度
        public void rotateSomePage(string inputPdf, string outputPdf)
        {
            PdfReader reader = new PdfReader(inputPdf);
            int pagesCount = reader.NumberOfPages;
            for (int n = 0; n < pagesCount; n++)
            {
                StackPanel stack = (StackPanel)PageListBox.Items[n];
                ComboBox comboBox = (ComboBox)stack.Children[1];
                if(comboBox.SelectedIndex>=0&&comboBox.SelectedIndex<=2)
                {
                    int degree = (comboBox.SelectedIndex + 1) * 90;
                    PdfDictionary page = reader.GetPageN(n+1);
                    PdfNumber rotate = page.GetAsNumber(PdfName.ROTATE);
                    int rotation =
                            rotate == null ? degree : (rotate.IntValue + degree) % 360;

                    page.Put(PdfName.ROTATE, new PdfNumber(rotation));
                }
            }
            PdfStamper stamper = new PdfStamper(reader, File.Create(outputPdf));
            stamper.Close();
            reader.Close();
        }

        private void AllRotateButton_Click(object sender, RoutedEventArgs e)
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
                    MessageTextBlock.Text = "完成！";
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
        }

        //一次旋轉所有頁面相同的角度
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

        //載入PDF頁數，並動態加入ComboBox至ListBox，用來各別指定各別頁面角度
        public void setupListBox(int pageCount)
        {
            for(int i=1;i<=pageCount;i++)
            {
                //stack panels  
                StackPanel stk = new StackPanel();
                stk.Name = "stack" + i;
                stk.Orientation = Orientation.Horizontal;
                stk.HorizontalAlignment = HorizontalAlignment.Left;
                //// textblock   
                TextBlock text = new TextBlock();
                text.Name = "text" + i;
                text.Text = ""+i;
                text.FontSize = 20;
                text.VerticalAlignment = VerticalAlignment.Center;
                // combobox
                ComboBox comboBox = new ComboBox();
                comboBox.Name = "comboBox" + i;
                TextBlock rightText = new TextBlock();
                rightText.Text = "右轉90度";
                rightText.FontSize = 15;
                TextBlock halfText = new TextBlock();
                halfText.Text = "轉180度";
                halfText.FontSize = 15;
                TextBlock leftText = new TextBlock();
                leftText.Text = "左轉90度";
                leftText.FontSize = 15;
                comboBox.Items.Add(rightText);
                comboBox.Items.Add(halfText);
                comboBox.Items.Add(leftText);

                //Add child elements to stack panel order important, last will be on right  
                stk.Children.Add(text);  // index 0  
                stk.Children.Add(comboBox);  // index 1  
                //Add to the listbox  
                PageListBox.Items.Add(stk);
            }
        }
    }
}
