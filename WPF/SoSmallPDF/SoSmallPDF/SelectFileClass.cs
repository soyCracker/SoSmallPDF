using Microsoft.Win32;

namespace SoSmallPDF
{
    class SelectFileClass
    {
        string selectFileName;
        string restoreDirectory;

        public string selectFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(!string.IsNullOrEmpty(restoreDirectory))
            {
                fileDialog.InitialDirectory = restoreDirectory;
            }
            else
            {
                fileDialog.InitialDirectory = "c:\\";
            }
            
            fileDialog.Filter = "pdf files (*.pdf)|*.pdf";

            if (fileDialog.ShowDialog() == true)
            {
                string[] filePathTemp = fileDialog.FileName.Split('\\');
                restoreDirectory = "";
                for (int i=0;i<filePathTemp.Length-1;i++)
                {
                    restoreDirectory += filePathTemp[i] + '\\';
                }
                selectFileName = fileDialog.FileName;
                return fileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public string saveFile()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            //default file name,original name add "SS"
            string[] filePathTemp = selectFileName.Split('\\');
            string[] fileNameTemp = filePathTemp[filePathTemp.Length - 1].Split('.');
            string oFileName = "";
            for(int i=0;i<fileNameTemp.Length-1;i++)
            {
                oFileName += fileNameTemp[i];
            }
            fileDialog.FileName = oFileName + "SS";
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
