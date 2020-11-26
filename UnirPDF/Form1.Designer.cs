namespace UnirPDF
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btSelectDirEnt = new System.Windows.Forms.Button();
            this.txtSelectDirEnt = new System.Windows.Forms.TextBox();
            this.txtSelectDirSai = new System.Windows.Forms.TextBox();
            this.btSelectDirSai = new System.Windows.Forms.Button();
            this.btUnir = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.checkBoxApagar = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rtbLogger = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btSelectDirEnt
            // 
            this.btSelectDirEnt.Location = new System.Drawing.Point(408, 10);
            this.btSelectDirEnt.Name = "btSelectDirEnt";
            this.btSelectDirEnt.Size = new System.Drawing.Size(30, 23);
            this.btSelectDirEnt.TabIndex = 0;
            this.btSelectDirEnt.Text = "...";
            this.btSelectDirEnt.UseVisualStyleBackColor = true;
            this.btSelectDirEnt.Click += new System.EventHandler(this.btSelectDirEnt_Click);
            // 
            // txtSelectDirEnt
            // 
            this.txtSelectDirEnt.Location = new System.Drawing.Point(122, 12);
            this.txtSelectDirEnt.Name = "txtSelectDirEnt";
            this.txtSelectDirEnt.Size = new System.Drawing.Size(280, 20);
            this.txtSelectDirEnt.TabIndex = 1;
            // 
            // txtSelectDirSai
            // 
            this.txtSelectDirSai.Location = new System.Drawing.Point(122, 38);
            this.txtSelectDirSai.Name = "txtSelectDirSai";
            this.txtSelectDirSai.Size = new System.Drawing.Size(280, 20);
            this.txtSelectDirSai.TabIndex = 3;
            // 
            // btSelectDirSai
            // 
            this.btSelectDirSai.Location = new System.Drawing.Point(408, 36);
            this.btSelectDirSai.Name = "btSelectDirSai";
            this.btSelectDirSai.Size = new System.Drawing.Size(30, 23);
            this.btSelectDirSai.TabIndex = 2;
            this.btSelectDirSai.Text = "...";
            this.btSelectDirSai.UseVisualStyleBackColor = true;
            this.btSelectDirSai.Click += new System.EventHandler(this.btSelectDirSai_Click);
            // 
            // btUnir
            // 
            this.btUnir.Location = new System.Drawing.Point(313, 71);
            this.btUnir.Name = "btUnir";
            this.btUnir.Size = new System.Drawing.Size(127, 23);
            this.btUnir.TabIndex = 4;
            this.btUnir.Text = "Unir PDFs";
            this.btUnir.UseVisualStyleBackColor = true;
            this.btUnir.Click += new System.EventHandler(this.btUnir_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Diretório de Saída:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(104, 13);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Diretório de Entrada:";
            // 
            // checkBoxApagar
            // 
            this.checkBoxApagar.AutoSize = true;
            this.checkBoxApagar.Location = new System.Drawing.Point(15, 75);
            this.checkBoxApagar.Name = "checkBoxApagar";
            this.checkBoxApagar.Size = new System.Drawing.Size(219, 17);
            this.checkBoxApagar.TabIndex = 21;
            this.checkBoxApagar.Text = "Apagar arquivos da Entrada após união?";
            this.checkBoxApagar.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(423, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // rtbLogger
            // 
            this.rtbLogger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLogger.Location = new System.Drawing.Point(17, 150);
            this.rtbLogger.Name = "rtbLogger";
            this.rtbLogger.ReadOnly = true;
            this.rtbLogger.Size = new System.Drawing.Size(421, 96);
            this.rtbLogger.TabIndex = 23;
            this.rtbLogger.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.rtbLogger);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBoxApagar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btUnir);
            this.Controls.Add(this.txtSelectDirSai);
            this.Controls.Add(this.btSelectDirSai);
            this.Controls.Add(this.txtSelectDirEnt);
            this.Controls.Add(this.btSelectDirEnt);
            this.Name = "Form1";
            this.Text = "Unir PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btSelectDirEnt;
        private System.Windows.Forms.TextBox txtSelectDirEnt;
        private System.Windows.Forms.TextBox txtSelectDirSai;
        private System.Windows.Forms.Button btSelectDirSai;
        private System.Windows.Forms.Button btUnir;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox checkBoxApagar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox rtbLogger;
    }
}

