namespace Comic_Packager_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_buscar = new System.Windows.Forms.Button();
            this.textbox_label = new System.Windows.Forms.TextBox();
            this.button_compress = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_errors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(12, 37);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(86, 32);
            this.button_buscar.TabIndex = 1;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_label
            // 
            this.textbox_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_label.Location = new System.Drawing.Point(104, 39);
            this.textbox_label.Name = "textbox_label";
            this.textbox_label.Size = new System.Drawing.Size(456, 30);
            this.textbox_label.TabIndex = 2;
            // 
            // button_compress
            // 
            this.button_compress.Location = new System.Drawing.Point(226, 102);
            this.button_compress.Name = "button_compress";
            this.button_compress.Size = new System.Drawing.Size(138, 62);
            this.button_compress.TabIndex = 3;
            this.button_compress.Text = "TO .CBZ";
            this.button_compress.UseVisualStyleBackColor = true;
            this.button_compress.Click += new System.EventHandler(this.button_compress_Click);
            // 
            // label_errors
            // 
            this.label_errors.AutoSize = true;
            this.label_errors.Location = new System.Drawing.Point(12, 227);
            this.label_errors.Name = "label_errors";
            this.label_errors.Size = new System.Drawing.Size(0, 17);
            this.label_errors.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.label_errors);
            this.Controls.Add(this.button_compress);
            this.Controls.Add(this.textbox_label);
            this.Controls.Add(this.button_buscar);
            this.Name = "Form1";
            this.Text = "Comic-Packager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.TextBox textbox_label;
        private System.Windows.Forms.Button button_compress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label_errors;
    }
}

