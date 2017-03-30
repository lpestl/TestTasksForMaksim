using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01_FindWordInDir
{
    public partial class MainFowm : Form
    {
        public MainFowm()
        {
            InitializeComponent();

            textBoxPath.Text = folderBrowserDialog.SelectedPath;

            toolStripStatusLabelMain.Text = "Running the application";
            toolStripProgressBar.Visible = false;
            toolStripStatusLabelDesc.Text = "Edit settings";
        }
        
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxPath.Text = folderBrowserDialog.SelectedPath;
            toolStripStatusLabelDesc.Text = "Browse folder \"" + folderBrowserDialog.SelectedPath + "\"";
        }

        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelDesc.Text = "File extension change on " + textBoxExtension.Text;
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelDesc.Text = "Browse folder \"" + textBoxPath.Text + "\"";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelDesc.Text = "Changed searching text on \"" + textBoxSearch.Text + "\"";
        }

        private void textBoxReplace_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelDesc.Text = "Changed replace text on \"" + textBoxReplace.Text + "\"";
        }

        //private Thread thread = null;
        private long count;
        private async void buttonSesrch_Click(object sender, EventArgs e)
        {
            dataGridViewFiles.Rows.Clear();

                buttonSesrch.Enabled = false;
                toolStripStatusLabelDesc.Text = "Setup settings...";
                Controller ctrl = new Controller();

                ctrl.PathFile = textBoxPath.Text;
                ctrl.Extension = textBoxExtension.Text;
                ctrl.SearchText = textBoxSearch.Text;
                ctrl.ReplaceText = textBoxReplace.Text;

                count = 0;
                var statusProgress = new Progress<string>(s => toolStripStatusLabelDesc.Text = s);
                //var replaceProgress = new Progress<int>(s => { labelCountOfReplace.Text = String.Format("Count of replace: {0}", s); });
                var filesProgress = new Progress<string>(s =>
                {
                    dataGridViewFiles.Rows.Add(Path.GetFileName(s), s);
                    labelFilesFound.Text = String.Format("Files found: {0}", count++);
                });
            try
            {
                await Task.Factory.StartNew(() => ctrl.StartProccesThread(filesProgress, statusProgress),
                                             TaskCreationOptions.LongRunning);
            }
            catch(Exception ex)
            {

            }   
            finally
            {
                buttonSesrch.Enabled = true;
            }  
        }
        
        private void MainFowm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
