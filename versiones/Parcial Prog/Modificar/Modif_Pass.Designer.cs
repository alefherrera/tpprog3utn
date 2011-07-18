namespace WindowsFormsApplication1
{
    partial class Modif_Pass
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_passnueva = new System.Windows.Forms.TextBox();
            this.botonaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(15, 25);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 20);
            this.tb_user.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(15, 64);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña nueva";
            // 
            // tb_passnueva
            // 
            this.tb_passnueva.Location = new System.Drawing.Point(15, 103);
            this.tb_passnueva.Name = "tb_passnueva";
            this.tb_passnueva.Size = new System.Drawing.Size(100, 20);
            this.tb_passnueva.TabIndex = 5;
            // 
            // botonaceptar
            // 
            this.botonaceptar.Location = new System.Drawing.Point(127, 25);
            this.botonaceptar.Name = "botonaceptar";
            this.botonaceptar.Size = new System.Drawing.Size(75, 23);
            this.botonaceptar.TabIndex = 6;
            this.botonaceptar.Text = "Aceptar";
            this.botonaceptar.UseVisualStyleBackColor = true;
            this.botonaceptar.Click += new System.EventHandler(this.botonaceptar_Click);
            // 
            // Modif_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 131);
            this.Controls.Add(this.botonaceptar);
            this.Controls.Add(this.tb_passnueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label1);
            this.Name = "Modif_Pass";
            this.Text = "Modif_Pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_passnueva;
        private System.Windows.Forms.Button botonaceptar;
    }
}