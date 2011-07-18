namespace WindowsFormsApplication1
{
    partial class Login
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.logear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(104, 27);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 20);
            this.tb_user.TabIndex = 0;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(104, 69);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 1;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(25, 27);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(43, 13);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "Usuario";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Location = new System.Drawing.Point(25, 69);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(61, 13);
            this.labelpass.TabIndex = 3;
            this.labelpass.Text = "Contraseña";
            // 
            // logear
            // 
            this.logear.Location = new System.Drawing.Point(249, 69);
            this.logear.Name = "logear";
            this.logear.Size = new System.Drawing.Size(75, 23);
            this.logear.TabIndex = 4;
            this.logear.Text = "Aceptar";
            this.logear.UseVisualStyleBackColor = true;
            this.logear.Click += new System.EventHandler(this.logear_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 123);
            this.Controls.Add(this.logear);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Button logear;
    }
}