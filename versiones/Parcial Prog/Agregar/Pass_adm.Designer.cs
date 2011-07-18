namespace WindowsFormsApplication1
{
    partial class Pass_adm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // botonaceptar
            // 
            this.botonaceptar.Location = new System.Drawing.Point(118, 10);
            this.botonaceptar.Name = "botonaceptar";
            this.botonaceptar.Size = new System.Drawing.Size(75, 23);
            this.botonaceptar.TabIndex = 1;
            this.botonaceptar.Text = "Aceptar";
            this.botonaceptar.UseVisualStyleBackColor = true;
            this.botonaceptar.Click += new System.EventHandler(this.botonaceptar_Click);
            // 
            // Pass_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 41);
            this.Controls.Add(this.botonaceptar);
            this.Controls.Add(this.textBox1);
            this.Name = "Pass_adm";
            this.Text = "Pass_adm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonaceptar;
    }
}