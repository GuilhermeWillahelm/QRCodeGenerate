namespace QrCodeGenerate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.urlLink = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.qrCodeImage = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtNameFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o link:";
            // 
            // urlLink
            // 
            this.urlLink.Location = new System.Drawing.Point(32, 72);
            this.urlLink.Name = "urlLink";
            this.urlLink.Size = new System.Drawing.Size(348, 23);
            this.urlLink.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(32, 204);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(173, 52);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Gerar QRCode";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // qrCodeImage
            // 
            this.qrCodeImage.Location = new System.Drawing.Point(32, 282);
            this.qrCodeImage.Name = "qrCodeImage";
            this.qrCodeImage.Size = new System.Drawing.Size(348, 336);
            this.qrCodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrCodeImage.TabIndex = 3;
            this.qrCodeImage.TabStop = false;
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFolder.Location = new System.Drawing.Point(211, 204);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(173, 52);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Selecionar Pasta";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtNameFile
            // 
            this.txtNameFile.Location = new System.Drawing.Point(32, 156);
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.Size = new System.Drawing.Size(348, 23);
            this.txtNameFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insira o nome do QRCode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameFile);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.qrCodeImage);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.urlLink);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox urlLink;
        private Button btnGenerate;
        private PictureBox qrCodeImage;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnFolder;
        private TextBox txtNameFile;
        private Label label2;
    }
}