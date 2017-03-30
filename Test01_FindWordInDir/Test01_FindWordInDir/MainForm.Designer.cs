namespace Test01_FindWordInDir
{
    partial class MainFowm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonSesrch = new System.Windows.Forms.Button();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.labelReplace = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSerch = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelFilesFound = new System.Windows.Forms.Label();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSettings.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(423, 17);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(96, 19);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(321, 20);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(10, 22);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(32, 13);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Path:";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.buttonSesrch);
            this.groupBoxSettings.Controls.Add(this.textBoxReplace);
            this.groupBoxSettings.Controls.Add(this.labelReplace);
            this.groupBoxSettings.Controls.Add(this.textBoxSearch);
            this.groupBoxSettings.Controls.Add(this.labelSerch);
            this.groupBoxSettings.Controls.Add(this.textBoxExtension);
            this.groupBoxSettings.Controls.Add(this.labelExtension);
            this.groupBoxSettings.Controls.Add(this.textBoxPath);
            this.groupBoxSettings.Controls.Add(this.labelPath);
            this.groupBoxSettings.Controls.Add(this.buttonBrowse);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(650, 141);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // buttonSesrch
            // 
            this.buttonSesrch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSesrch.Location = new System.Drawing.Point(423, 108);
            this.buttonSesrch.Name = "buttonSesrch";
            this.buttonSesrch.Size = new System.Drawing.Size(221, 23);
            this.buttonSesrch.TabIndex = 9;
            this.buttonSesrch.Text = "Search and replace";
            this.buttonSesrch.UseVisualStyleBackColor = true;
            this.buttonSesrch.Click += new System.EventHandler(this.buttonSesrch_Click);
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplace.Location = new System.Drawing.Point(96, 82);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(548, 20);
            this.textBoxReplace.TabIndex = 8;
            this.textBoxReplace.Text = "repsecond";
            this.textBoxReplace.TextChanged += new System.EventHandler(this.textBoxReplace_TextChanged);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(10, 85);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(62, 13);
            this.labelReplace.TabIndex = 7;
            this.labelReplace.Text = "Replace to:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(96, 51);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(548, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.Text = "second";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSerch
            // 
            this.labelSerch.AutoSize = true;
            this.labelSerch.Location = new System.Drawing.Point(10, 54);
            this.labelSerch.Name = "labelSerch";
            this.labelSerch.Size = new System.Drawing.Size(64, 13);
            this.labelSerch.TabIndex = 5;
            this.labelSerch.Text = "Search text:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtension.Location = new System.Drawing.Point(584, 19);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(60, 20);
            this.textBoxExtension.TabIndex = 4;
            this.textBoxExtension.Text = ".txt";
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // labelExtension
            // 
            this.labelExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(504, 22);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(74, 13);
            this.labelExtension.TabIndex = 3;
            this.labelExtension.Text = "File extension:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain,
            this.toolStripProgressBar,
            this.toolStripStatusLabelDesc});
            this.statusStrip.Location = new System.Drawing.Point(0, 483);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(674, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.AutoSize = false;
            this.toolStripStatusLabelMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabelMain.Text = "Info";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(150, 16);
            // 
            // toolStripStatusLabelDesc
            // 
            this.toolStripStatusLabelDesc.Name = "toolStripStatusLabelDesc";
            this.toolStripStatusLabelDesc.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabelDesc.Text = "Current action";
            // 
            // labelFilesFound
            // 
            this.labelFilesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilesFound.AutoSize = true;
            this.labelFilesFound.Location = new System.Drawing.Point(487, 160);
            this.labelFilesFound.Name = "labelFilesFound";
            this.labelFilesFound.Size = new System.Drawing.Size(61, 13);
            this.labelFilesFound.TabIndex = 6;
            this.labelFilesFound.Text = "Files found:";
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FullPath});
            this.dataGridViewFiles.Location = new System.Drawing.Point(13, 160);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.Size = new System.Drawing.Size(468, 320);
            this.dataGridViewFiles.TabIndex = 8;
            // 
            // FileName
            // 
            this.FileName.FillWeight = 200F;
            this.FileName.HeaderText = "File name";
            this.FileName.Name = "FileName";
            this.FileName.Width = 200;
            // 
            // FullPath
            // 
            this.FullPath.FillWeight = 500F;
            this.FullPath.HeaderText = "Full path";
            this.FullPath.Name = "FullPath";
            this.FullPath.Width = 500;
            // 
            // MainFowm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 505);
            this.Controls.Add(this.dataGridViewFiles);
            this.Controls.Add(this.labelFilesFound);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "MainFowm";
            this.Text = "Find all files and replace text";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFowm_FormClosed);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSerch;
        private System.Windows.Forms.Button buttonSesrch;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDesc;
        private System.Windows.Forms.Label labelFilesFound;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
    }
}

