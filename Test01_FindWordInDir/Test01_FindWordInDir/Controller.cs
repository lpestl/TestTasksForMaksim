using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01_FindWordInDir
{
    class Controller
    {
        #region Properties 
        public String PathFile { get; set; }
        public String Extension { get; set; }
        public String SearchText { get; set; }
        public String ReplaceText { get; set; }

        //private FindFileCallback ffCallback;
        //private ReplaceCounter counterCallback;
        //private StatusInfo statusCallback;

        //private int countFiles;
        //private int countReplaces;
        #endregion

        //#region Delegates
        //// delegate for find file callback
        //public delegate void FindFileCallback(String _name, String _path, int _count);
        //public delegate void ReplaceCounter(int _count);
        //public delegate void StatusInfo(String _info);
        //#endregion

        #region Methods
        public Controller()
        {
            ReplaceText = SearchText = Extension = PathFile = string.Empty;

            //ffCallback = null;
            //counterCallback = null;
            //statusCallback = null;
        }

        /*public Controller(FindFileCallback _ffcllb, ReplaceCounter _rccllb, StatusInfo _stInfo)
        {
            ffCallback = _ffcllb;
            counterCallback = _rccllb;
            statusCallback = _stInfo;
        }*/

        private void CheckSettings()
        {
            if (PathFile == null) throw new ArgumentNullException();
            if (!Directory.Exists(PathFile))
            {
                throw new System.IO.DirectoryNotFoundException();
            }

            if (Extension == null) throw new ArgumentNullException();

            if (SearchText == null) throw new ArgumentNullException();
            if (SearchText == "") throw new ArgumentNullException();

            if (ReplaceText == null) throw new ArgumentNullException();

            //if (ffCallback == null) throw new ArgumentNullException();
            //if (counterCallback == null) throw new ArgumentNullException();
            //if (statusCallback == null) throw new ArgumentNullException();
        }

        public void StartProccesThread(IProgress<string> filesProgress, IProgress<string> statusProgress)
        {
            //statusCallback("Checking settings...");
            try
            {
                CheckSettings();
            }
            catch (DirectoryNotFoundException dirEx)
            {
                //statusCallback("Directory not found");
                MessageBox.Show("Directory not found: " + dirEx.Message, "Wrong path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException e)
            {
                //statusCallback("Null Exception: " + e.Message);
                MessageBox.Show(e.Message, "Null Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //statusCallback("Settings up");

            //statusCallback("Search for files in the directory...");
            //countFiles = 0;
            //List <String> files = new List<String>();
            //files = SearchInDirectory(Path);

            SearchInDirectory(PathFile, filesProgress, statusProgress);
        }

        public void SearchInDirectory(string _sDir, IProgress<string> filesProgress, IProgress<string> statusProgress)
        {
            try
            {
                foreach (string file in Directory.GetFiles(_sDir))
                {
                    if (Path.GetExtension(file).IndexOf(Extension.ToLower()) >= 0)
                    {
                        filesProgress.Report(file);
                        statusProgress.Report(String.Format("Finded file \"{0}\"", file));
                        OpenFileAndReplace(file, statusProgress);
                    }
                }
                foreach (string dir in Directory.GetDirectories(_sDir))
                {
                    SearchInDirectory(dir, filesProgress, statusProgress);
                }
            }
            catch (System.Exception excpt)
            {
                statusProgress.Report(excpt.Message);
            }
            statusProgress.Report("Success");
        }

        public void OpenFileAndReplace(string _file, IProgress<string> statusProgress)
        {
            statusProgress.Report(String.Format("Reading file \"{0}\"", _file));
            StreamReader reader = new StreamReader(_file);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, SearchText, ReplaceText);

            statusProgress.Report(String.Format("Replacing in file \"{0}\"", _file));
            StreamWriter writer = new StreamWriter(_file);
            writer.Write(content);
            writer.Close();
        }

        #endregion
    }
}
