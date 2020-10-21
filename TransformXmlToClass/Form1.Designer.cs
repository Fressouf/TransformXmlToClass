namespace TransformXmlToClass
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.xmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnXmlFileBrowse = new System.Windows.Forms.Button();
            this.btnOutputDirectoryBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblDateFormatSample = new System.Windows.Forms.Label();
            this.lblDateTimeFormatSample = new System.Windows.Forms.Label();
            this.txtXmlFileLocation = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNamespace = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtOutputDirectory = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDateFormat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDateTimeFormat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichier XML";
            // 
            // xmlOpenFileDialog
            // 
            this.xmlOpenFileDialog.Filter = "XML files|*.xml|All files|*.*";
            // 
            // btnXmlFileBrowse
            // 
            this.btnXmlFileBrowse.Location = new System.Drawing.Point(384, 47);
            this.btnXmlFileBrowse.Name = "btnXmlFileBrowse";
            this.btnXmlFileBrowse.Size = new System.Drawing.Size(64, 23);
            this.btnXmlFileBrowse.TabIndex = 2;
            this.btnXmlFileBrowse.Text = "Browse";
            this.btnXmlFileBrowse.UseVisualStyleBackColor = true;
            // 
            // btnOutputDirectoryBrowse
            // 
            this.btnOutputDirectoryBrowse.Location = new System.Drawing.Point(393, 290);
            this.btnOutputDirectoryBrowse.Name = "btnOutputDirectoryBrowse";
            this.btnOutputDirectoryBrowse.Size = new System.Drawing.Size(64, 23);
            this.btnOutputDirectoryBrowse.TabIndex = 5;
            this.btnOutputDirectoryBrowse.Text = "Browse";
            this.btnOutputDirectoryBrowse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(130, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Namespace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(133, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(133, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DateTime Format";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(153, 350);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(64, 23);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // lblDateFormatSample
            // 
            this.lblDateFormatSample.AutoSize = true;
            this.lblDateFormatSample.Location = new System.Drawing.Point(402, 184);
            this.lblDateFormatSample.Name = "lblDateFormatSample";
            this.lblDateFormatSample.Size = new System.Drawing.Size(46, 13);
            this.lblDateFormatSample.TabIndex = 14;
            this.lblDateFormatSample.Text = "sample: ";
            // 
            // lblDateTimeFormatSample
            // 
            this.lblDateTimeFormatSample.AutoSize = true;
            this.lblDateTimeFormatSample.Location = new System.Drawing.Point(402, 233);
            this.lblDateTimeFormatSample.Name = "lblDateTimeFormatSample";
            this.lblDateTimeFormatSample.Size = new System.Drawing.Size(46, 13);
            this.lblDateTimeFormatSample.TabIndex = 15;
            this.lblDateTimeFormatSample.Text = "sample: ";
            // 
            // txtXmlFileLocation
            // 
            this.txtXmlFileLocation.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtXmlFileLocation.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.txtXmlFileLocation.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtXmlFileLocation.BorderThickness = 1;
            this.txtXmlFileLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXmlFileLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtXmlFileLocation.ForeColor = System.Drawing.Color.Gray;
            this.txtXmlFileLocation.isPassword = false;
            this.txtXmlFileLocation.Location = new System.Drawing.Point(133, 47);
            this.txtXmlFileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtXmlFileLocation.Name = "txtXmlFileLocation";
            this.txtXmlFileLocation.Size = new System.Drawing.Size(244, 33);
            this.txtXmlFileLocation.TabIndex = 103;
            this.txtXmlFileLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNamespace
            // 
            this.txtNamespace.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNamespace.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.txtNamespace.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNamespace.BorderThickness = 1;
            this.txtNamespace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamespace.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNamespace.ForeColor = System.Drawing.Color.Gray;
            this.txtNamespace.isPassword = false;
            this.txtNamespace.Location = new System.Drawing.Point(133, 95);
            this.txtNamespace.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(242, 33);
            this.txtNamespace.TabIndex = 104;
            this.txtNamespace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOutputDirectory.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.txtOutputDirectory.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOutputDirectory.BorderThickness = 1;
            this.txtOutputDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputDirectory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOutputDirectory.ForeColor = System.Drawing.Color.Gray;
            this.txtOutputDirectory.isPassword = false;
            this.txtOutputDirectory.Location = new System.Drawing.Point(131, 290);
            this.txtOutputDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(244, 33);
            this.txtOutputDirectory.TabIndex = 105;
            this.txtOutputDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDateFormat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.txtDateFormat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDateFormat.BorderThickness = 1;
            this.txtDateFormat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateFormat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDateFormat.ForeColor = System.Drawing.Color.Gray;
            this.txtDateFormat.isPassword = false;
            this.txtDateFormat.Location = new System.Drawing.Point(133, 164);
            this.txtDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(242, 33);
            this.txtDateFormat.TabIndex = 106;
            this.txtDateFormat.Text = "YYYY-MM-DD";
            this.txtDateFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateTimeFormat
            // 
            this.txtDateTimeFormat.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDateTimeFormat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.txtDateTimeFormat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDateTimeFormat.BorderThickness = 1;
            this.txtDateTimeFormat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateTimeFormat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDateTimeFormat.ForeColor = System.Drawing.Color.Gray;
            this.txtDateTimeFormat.isPassword = false;
            this.txtDateTimeFormat.Location = new System.Drawing.Point(133, 218);
            this.txtDateTimeFormat.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateTimeFormat.Name = "txtDateTimeFormat";
            this.txtDateTimeFormat.Size = new System.Drawing.Size(242, 33);
            this.txtDateTimeFormat.TabIndex = 107;
            this.txtDateTimeFormat.Text = "YYYY-MM-DDThh:mm:sss";
            this.txtDateTimeFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDateTimeFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXmlFileLocation);
            this.Controls.Add(this.lblDateTimeFormatSample);
            this.Controls.Add(this.lblDateFormatSample);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOutputDirectoryBrowse);
            this.Controls.Add(this.btnXmlFileBrowse);
            this.Name = "Form1";
            this.Text = "Xml To Serialisable c# Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog xmlOpenFileDialog;
        private System.Windows.Forms.Button btnXmlFileBrowse;
        private System.Windows.Forms.Button btnOutputDirectoryBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblDateFormatSample;
        private System.Windows.Forms.Label lblDateTimeFormatSample;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtXmlFileLocation;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNamespace;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOutputDirectory;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDateFormat;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDateTimeFormat;
    }
}

        


