namespace WindowsFormsApplication1
{
    partial class Agregar_Artxprov
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
            this.botonagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_art = new System.Windows.Forms.ComboBox();
            this.cb_prov = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botonagregar
            // 
            this.botonagregar.Location = new System.Drawing.Point(157, 72);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Size = new System.Drawing.Size(75, 23);
            this.botonagregar.TabIndex = 0;
            this.botonagregar.Text = "Agregar";
            this.botonagregar.UseVisualStyleBackColor = true;
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Articulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Proveedor";
            // 
            // cb_art
            // 
            this.cb_art.FormattingEnabled = true;
            this.cb_art.Location = new System.Drawing.Point(12, 32);
            this.cb_art.Name = "cb_art";
            this.cb_art.Size = new System.Drawing.Size(121, 21);
            this.cb_art.TabIndex = 6;
            // 
            // cb_prov
            // 
            this.cb_prov.FormattingEnabled = true;
            this.cb_prov.Location = new System.Drawing.Point(12, 76);
            this.cb_prov.Name = "cb_prov";
            this.cb_prov.Size = new System.Drawing.Size(121, 21);
            this.cb_prov.TabIndex = 7;
            // 
            // Agregar_Artxprov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 107);
            this.Controls.Add(this.cb_prov);
            this.Controls.Add(this.cb_art);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonagregar);
            this.Name = "Agregar_Artxprov";
            this.Text = "Agregar_Artxprov";
            this.Load += new System.EventHandler(this.Agregar_Artxprov_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_art;
        private System.Windows.Forms.ComboBox cb_prov;
    }
}