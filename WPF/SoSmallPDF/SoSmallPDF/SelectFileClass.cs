using Microsoft.Win32;

namespace SoSmallPDF
{
    class SelectFileClass
    {
        public string selectFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "pdf files (*.pdf)|*.pdf";
            //fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == true)
            {
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
            fileDialog.FileName = "Document"; //default file name
            fileDialog.DefaultExt = ".pdf"; //default file extension
            fileDialog.Filter = "pdf files (*.pdf)|*.pdf"; //filter files by extension

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
