using Microsoft.Win32;
using System.IO;

namespace SoSmallPDF
{
    //檔案選擇器
    class SelectFileClass
    {
        string selectFileName;
        string restoreDirectory;

        //開啟檔案
        public string selectFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(!string.IsNullOrEmpty(restoreDirectory))
            {
                //檔案選擇器記憶上一次位置
                fileDialog.InitialDirectory = restoreDirectory;
            }
            else
            {
                //檔案選擇器初始位置
                fileDialog.InitialDirectory = "c:\\";
            }
            
            //副檔名PDF
            fileDialog.Filter = "pdf files (*.pdf)|*.pdf";

            if (fileDialog.ShowDialog() == true)
            {
                //去掉檔名，檔案選擇器記錄這一次位置
                restoreDirectory = Path.GetDirectoryName(fileDialog.FileName);
                selectFileName = fileDialog.FileName;
                return fileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        //存檔
        public string saveFile()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            //預設存檔名為：原檔名+SS
            fileDialog.FileName = Path.GetFileNameWithoutExtension(selectFileName) + "SS";
            //fileDialog.FileName = original FileName + "SS";
            //default file extension
            fileDialog.DefaultExt = ".pdf";
            //filter files by extension
            fileDialog.Filter = "pdf files (*.pdf)|*.pdf"; 

            // Process save file dialog box results
            if (fileDialog.ShowDialog() == true)
            {
                // Save document
                return fileDialog.FileName;
            }
            else
            {
                return null;
            }
        }
    }
}
