namespace Unscrambler
{
    partial class UnscrambleForm
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
            this.bkgrndFileReader = new System.ComponentModel.BackgroundWorker();
            this.btnLoadDictionary = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScrambledLetters = new System.Windows.Forms.Label();
            this.lblDictionaryPath = new System.Windows.Forms.Label();
            this.txtDictionaryPath = new System.Windows.Forms.TextBox();
            this.txtScrambledLetters = new System.Windows.Forms.TextBox();
            this.btnGetWords = new System.Windows.Forms.Button();
            this.statFileLoading = new System.Windows.Forms.StatusStrip();
            this.lblLoadingFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.statFileLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // bkgrndFileReader
            // 
            this.bkgrndFileReader.WorkerReportsProgress = true;
            this.bkgrndFileReader.WorkerSupportsCancellation = true;
            this.bkgrndFileReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgrndFileReader_DoWork);
            this.bkgrndFileReader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgrndFileReader_ProgressChanged);
            this.bkgrndFileReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgrndFileReader_RunWorkerCompleted);
            // 
            // btnLoadDictionary
            // 
            this.btnLoadDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnLoadDictionary, 3);
            this.btnLoadDictionary.Location = new System.Drawing.Point(3, 28);
            this.btnLoadDictionary.Name = "btnLoadDictionary";
            this.btnLoadDictionary.Size = new System.Drawing.Size(547, 24);
            this.btnLoadDictionary.TabIndex = 0;
            this.btnLoadDictionary.Text = "&Load Dictionary";
            this.btnLoadDictionary.UseVisualStyleBackColor = true;
            this.btnLoadDictionary.Click += new System.EventHandler(this.btnLoadDictionary_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.lblScrambledLetters, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDictionaryPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDictionaryPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadDictionary, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGetWords, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtScrambledLetters, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 114);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblScrambledLetters
            // 
            this.lblScrambledLetters.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScrambledLetters.AutoSize = true;
            this.lblScrambledLetters.Location = new System.Drawing.Point(12, 63);
            this.lblScrambledLetters.Name = "lblScrambledLetters";
            this.lblScrambledLetters.Size = new System.Drawing.Size(95, 13);
            this.lblScrambledLetters.TabIndex = 4;
            this.lblScrambledLetters.Text = "Scrambled Letters:";
            this.lblScrambledLetters.Visible = false;
            // 
            // lblDictionaryPath
            // 
            this.lblDictionaryPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDictionaryPath.AutoSize = true;
            this.lblDictionaryPath.Location = new System.Drawing.Point(25, 6);
            this.lblDictionaryPath.Name = "lblDictionaryPath";
            this.lblDictionaryPath.Size = new System.Drawing.Size(82, 13);
            this.lblDictionaryPath.TabIndex = 3;
            this.lblDictionaryPath.Text = "Dictionary Path:";
            // 
            // txtDictionaryPath
            // 
            this.txtDictionaryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDictionaryPath, 2);
            this.txtDictionaryPath.Location = new System.Drawing.Point(113, 3);
            this.txtDictionaryPath.Name = "txtDictionaryPath";
            this.txtDictionaryPath.Size = new System.Drawing.Size(437, 20);
            this.txtDictionaryPath.TabIndex = 3;
            // 
            // txtScrambledLetters
            // 
            this.txtScrambledLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScrambledLetters.Location = new System.Drawing.Point(113, 58);
            this.txtScrambledLetters.Name = "txtScrambledLetters";
            this.txtScrambledLetters.Size = new System.Drawing.Size(272, 20);
            this.txtScrambledLetters.TabIndex = 5;
            this.txtScrambledLetters.Visible = false;
            this.txtScrambledLetters.Enter += new System.EventHandler(this.txtScrambledLetters_Enter);
            // 
            // btnGetWords
            // 
            this.btnGetWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetWords.Location = new System.Drawing.Point(391, 58);
            this.btnGetWords.Name = "btnGetWords";
            this.btnGetWords.Size = new System.Drawing.Size(159, 23);
            this.btnGetWords.TabIndex = 6;
            this.btnGetWords.Text = "&Get Words";
            this.btnGetWords.UseVisualStyleBackColor = true;
            this.btnGetWords.Visible = false;
            this.btnGetWords.Click += new System.EventHandler(this.btnGetWords_Click);
            // 
            // statFileLoading
            // 
            this.statFileLoading.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoadingFile});
            this.statFileLoading.Location = new System.Drawing.Point(0, 92);
            this.statFileLoading.Name = "statFileLoading";
            this.statFileLoading.Size = new System.Drawing.Size(553, 22);
            this.statFileLoading.TabIndex = 2;
            // 
            // lblLoadingFile
            // 
            this.lblLoadingFile.Name = "lblLoadingFile";
            this.lblLoadingFile.Size = new System.Drawing.Size(39, 17);
            this.lblLoadingFile.Text = "Ready";
            // 
            // UnscrambleForm
            // 
            this.AcceptButton = this.btnGetWords;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 114);
            this.Controls.Add(this.statFileLoading);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UnscrambleForm";
            this.Text = "Unscrambler";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statFileLoading.ResumeLayout(false);
            this.statFileLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bkgrndFileReader;
        private System.Windows.Forms.Button btnLoadDictionary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statFileLoading;
        private System.Windows.Forms.ToolStripStatusLabel lblLoadingFile;
        private System.Windows.Forms.Label lblDictionaryPath;
        private System.Windows.Forms.TextBox txtDictionaryPath;
        private System.Windows.Forms.Label lblScrambledLetters;
        private System.Windows.Forms.TextBox txtScrambledLetters;
        private System.Windows.Forms.Button btnGetWords;
    }
}

