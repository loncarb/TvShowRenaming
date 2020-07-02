namespace TvShowRenaming
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.chbUseFoldersStructureForRenaming = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSubtitleExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter root folder";
            // 
            // txtSelectedFolder
            // 
            this.txtSelectedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFolder.Location = new System.Drawing.Point(128, 36);
            this.txtSelectedFolder.Name = "txtSelectedFolder";
            this.txtSelectedFolder.Size = new System.Drawing.Size(310, 20);
            this.txtSelectedFolder.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(469, 35);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(570, 137);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(277, 11);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Waiting input...";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(30, 38);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(603, 277);
            this.txtLog.TabIndex = 5;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(36, 19);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(25, 13);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "Log";
            // 
            // chbUseFoldersStructureForRenaming
            // 
            this.chbUseFoldersStructureForRenaming.AutoSize = true;
            this.chbUseFoldersStructureForRenaming.Location = new System.Drawing.Point(42, 62);
            this.chbUseFoldersStructureForRenaming.Name = "chbUseFoldersStructureForRenaming";
            this.chbUseFoldersStructureForRenaming.Size = new System.Drawing.Size(192, 17);
            this.chbUseFoldersStructureForRenaming.TabIndex = 7;
            this.chbUseFoldersStructureForRenaming.Text = "Use Folder Structure For Renaming";
            this.chbUseFoldersStructureForRenaming.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblLog);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Location = new System.Drawing.Point(12, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 318);
            this.panel1.TabIndex = 8;
            // 
            // txtSubtitleExtension
            // 
            this.txtSubtitleExtension.Location = new System.Drawing.Point(42, 86);
            this.txtSubtitleExtension.Name = "txtSubtitleExtension";
            this.txtSubtitleExtension.Size = new System.Drawing.Size(100, 20);
            this.txtSubtitleExtension.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subtitle Extension";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubtitleExtension);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chbUseFoldersStructureForRenaming);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtSelectedFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.CheckBox chbUseFoldersStructureForRenaming;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSubtitleExtension;
        private System.Windows.Forms.Label label2;
    }
}

