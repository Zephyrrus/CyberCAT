namespace CyberCAT.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.metaInformationFilePathTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recompressFilePathTextbox = new System.Windows.Forms.TextBox();
            this.recompressButton = new System.Windows.Forms.Button();
            this.decompressFilePathTextbox = new System.Windows.Forms.TextBox();
            this.uncompressButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loadAppearanceSectionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.appearanceUncompressedSaveFilePathTextbox = new System.Windows.Forms.TextBox();
            this.openSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.openDecompressedSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.openMetaInfo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 225);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Metainfo File Path:";
            // 
            // metaInformationFilePathTextbox
            // 
            this.metaInformationFilePathTextbox.AllowDrop = true;
            this.metaInformationFilePathTextbox.Location = new System.Drawing.Point(6, 71);
            this.metaInformationFilePathTextbox.Name = "metaInformationFilePathTextbox";
            this.metaInformationFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.metaInformationFilePathTextbox.TabIndex = 7;
            this.metaInformationFilePathTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metaInformationFilePathTextbox_MouseClick);
            this.metaInformationFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.metaInformationFilePathTextbox_DragDrop);
            this.metaInformationFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.metaInformationFilePathTextbox_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Decompressed File Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save File Path:";
            // 
            // recompressFilePathTextbox
            // 
            this.recompressFilePathTextbox.AllowDrop = true;
            this.recompressFilePathTextbox.Location = new System.Drawing.Point(6, 32);
            this.recompressFilePathTextbox.Name = "recompressFilePathTextbox";
            this.recompressFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.recompressFilePathTextbox.TabIndex = 4;
            this.recompressFilePathTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recompressFilePathTextbox_MouseClick);
            this.recompressFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.recompressFilePathTextbox_DragDrop);
            this.recompressFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.recompressFilePathTextbox_DragEnter);
            // 
            // recompressButton
            // 
            this.recompressButton.Location = new System.Drawing.Point(419, 71);
            this.recompressButton.Name = "recompressButton";
            this.recompressButton.Size = new System.Drawing.Size(75, 23);
            this.recompressButton.TabIndex = 3;
            this.recompressButton.Text = "Recompress";
            this.recompressButton.UseVisualStyleBackColor = true;
            this.recompressButton.Click += new System.EventHandler(this.recompressButton_Click);
            // 
            // decompressFilePathTextbox
            // 
            this.decompressFilePathTextbox.AllowDrop = true;
            this.decompressFilePathTextbox.Location = new System.Drawing.Point(5, 36);
            this.decompressFilePathTextbox.Name = "decompressFilePathTextbox";
            this.decompressFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.decompressFilePathTextbox.TabIndex = 2;
            this.decompressFilePathTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.decompressFilePathTextbox_MouseClick);
            this.decompressFilePathTextbox.TextChanged += new System.EventHandler(this.decompressFilePathTextbox_TextChanged);
            this.decompressFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.decompressFilePathTextbox_DragDrop);
            this.decompressFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.decompressFilePathTextbox_DragEnter);
            // 
            // uncompressButton
            // 
            this.uncompressButton.Location = new System.Drawing.Point(418, 34);
            this.uncompressButton.Name = "uncompressButton";
            this.uncompressButton.Size = new System.Drawing.Size(75, 23);
            this.uncompressButton.TabIndex = 0;
            this.uncompressButton.Text = "Decompress";
            this.uncompressButton.UseVisualStyleBackColor = true;
            this.uncompressButton.Click += new System.EventHandler(this.uncompressButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loadAppearanceSectionButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.appearanceUncompressedSaveFilePathTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loadAppearanceSectionButton
            // 
            this.loadAppearanceSectionButton.Location = new System.Drawing.Point(447, 23);
            this.loadAppearanceSectionButton.Name = "loadAppearanceSectionButton";
            this.loadAppearanceSectionButton.Size = new System.Drawing.Size(75, 23);
            this.loadAppearanceSectionButton.TabIndex = 2;
            this.loadAppearanceSectionButton.Text = "Load";
            this.loadAppearanceSectionButton.UseVisualStyleBackColor = true;
            this.loadAppearanceSectionButton.Click += new System.EventHandler(this.loadAppearanceSectionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Uncompressed SaveFilePath";
            // 
            // appearanceUncompressedSaveFilePathTextbox
            // 
            this.appearanceUncompressedSaveFilePathTextbox.AllowDrop = true;
            this.appearanceUncompressedSaveFilePathTextbox.Location = new System.Drawing.Point(6, 23);
            this.appearanceUncompressedSaveFilePathTextbox.Name = "appearanceUncompressedSaveFilePathTextbox";
            this.appearanceUncompressedSaveFilePathTextbox.Size = new System.Drawing.Size(435, 20);
            this.appearanceUncompressedSaveFilePathTextbox.TabIndex = 0;
            this.appearanceUncompressedSaveFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.appearanceUncompressedSaveFilePathTextbox_DragDrop);
            this.appearanceUncompressedSaveFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.appearanceUncompressedSaveFilePathTextbox_DragEnter);
            // 
            // openMetaInfo
            // 
            this.openMetaInfo.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uncompressButton);
            this.groupBox1.Controls.Add(this.decompressFilePathTextbox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 71);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decompress save file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recompressFilePathTextbox);
            this.groupBox2.Controls.Add(this.recompressButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.metaInformationFilePathTextbox);
            this.groupBox2.Location = new System.Drawing.Point(6, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 106);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recompress save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 225);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CyberCAT";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button uncompressButton;
        private System.Windows.Forms.TextBox decompressFilePathTextbox;
        private System.Windows.Forms.Button recompressButton;
        private System.Windows.Forms.TextBox recompressFilePathTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metaInformationFilePathTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox appearanceUncompressedSaveFilePathTextbox;
        private System.Windows.Forms.Button loadAppearanceSectionButton;
        private System.Windows.Forms.OpenFileDialog openSaveFile;
        private System.Windows.Forms.OpenFileDialog openDecompressedSaveFile;
        private System.Windows.Forms.OpenFileDialog openMetaInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

