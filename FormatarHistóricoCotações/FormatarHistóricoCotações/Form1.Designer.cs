namespace FormatarHistóricoCotações
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
            this.FormatarArquivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Abrir = new System.Windows.Forms.Button();
            this.ConcatenaArquivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormatarArquivo
            // 
            this.FormatarArquivo.Location = new System.Drawing.Point(204, 175);
            this.FormatarArquivo.Name = "FormatarArquivo";
            this.FormatarArquivo.Size = new System.Drawing.Size(150, 46);
            this.FormatarArquivo.TabIndex = 0;
            this.FormatarArquivo.Text = "Formatar Arquivo";
            this.FormatarArquivo.UseVisualStyleBackColor = true;
            this.FormatarArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Abrir
            // 
            this.Abrir.Location = new System.Drawing.Point(12, 175);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(140, 46);
            this.Abrir.TabIndex = 1;
            this.Abrir.Text = "Abrir Arquivo Histórico";
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConcatenaArquivos
            // 
            this.ConcatenaArquivos.Location = new System.Drawing.Point(23, 42);
            this.ConcatenaArquivos.Name = "ConcatenaArquivos";
            this.ConcatenaArquivos.Size = new System.Drawing.Size(117, 48);
            this.ConcatenaArquivos.TabIndex = 2;
            this.ConcatenaArquivos.Text = "Concatena arquivos Históricos";
            this.ConcatenaArquivos.UseVisualStyleBackColor = true;
            this.ConcatenaArquivos.Click += new System.EventHandler(this.ConcatenaArquivos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 249);
            this.Controls.Add(this.ConcatenaArquivos);
            this.Controls.Add(this.Abrir);
            this.Controls.Add(this.FormatarArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "METE (Modelo e Estratégia Trade Erasmo)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FormatarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Abrir;
        private System.Windows.Forms.Button ConcatenaArquivos;
    }
}

