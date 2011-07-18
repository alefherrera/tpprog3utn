namespace WindowsFormsApplication1
{
    partial class Modif_Art
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
            this.botonmodif = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_error2 = new System.Windows.Forms.Label();
            this.lb_error3 = new System.Windows.Forms.Label();
            this.botonlimpiar = new System.Windows.Forms.Button();
            this.cb_art = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botonmodif
            // 
            this.botonmodif.Location = new System.Drawing.Point(127, 61);
            this.botonmodif.Name = "botonmodif";
            this.botonmodif.Size = new System.Drawing.Size(75, 23);
            this.botonmodif.TabIndex = 17;
            this.botonmodif.Text = "Modificar";
            this.botonmodif.UseVisualStyleBackColor = true;
            this.botonmodif.Click += new System.EventHandler(this.botonmodif_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(12, 188);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(100, 20);
            this.tb_stock.TabIndex = 12;
            this.tb_stock.TextChanged += new System.EventHandler(this.tb_stock_TextChanged);
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(12, 145);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(100, 20);
            this.tb_precio.TabIndex = 11;
            this.tb_precio.TextChanged += new System.EventHandler(this.tb_precio_TextChanged);
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(12, 102);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(100, 20);
            this.tb_marca.TabIndex = 10;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(12, 61);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Articulo";
            // 
            // lb_error2
            // 
            this.lb_error2.AutoSize = true;
            this.lb_error2.Location = new System.Drawing.Point(134, 145);
            this.lb_error2.Name = "lb_error2";
            this.lb_error2.Size = new System.Drawing.Size(35, 13);
            this.lb_error2.TabIndex = 21;
            this.lb_error2.Text = "label7";
            this.lb_error2.TextChanged += new System.EventHandler(this.lb_error2_TextChanged);
            // 
            // lb_error3
            // 
            this.lb_error3.AutoSize = true;
            this.lb_error3.Location = new System.Drawing.Point(134, 188);
            this.lb_error3.Name = "lb_error3";
            this.lb_error3.Size = new System.Drawing.Size(35, 13);
            this.lb_error3.TabIndex = 22;
            this.lb_error3.Text = "label8";
            this.lb_error3.TextChanged += new System.EventHandler(this.lb_error3_TextChanged);
            // 
            // botonlimpiar
            // 
            this.botonlimpiar.Location = new System.Drawing.Point(127, 102);
            this.botonlimpiar.Name = "botonlimpiar";
            this.botonlimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonlimpiar.TabIndex = 23;
            this.botonlimpiar.Text = "Limpiar";
            this.botonlimpiar.UseVisualStyleBackColor = true;
            this.botonlimpiar.Click += new System.EventHandler(this.botonlimpiar_Click);
            // 
            // cb_art
            // 
            this.cb_art.FormattingEnabled = true;
            this.cb_art.Location = new System.Drawing.Point(12, 21);
            this.cb_art.Name = "cb_art";
            this.cb_art.Size = new System.Drawing.Size(121, 21);
            this.cb_art.TabIndex = 24;
            this.cb_art.SelectedIndexChanged += new System.EventHandler(this.cb_art_SelectedIndexChanged);
            this.cb_art.Enter += new System.EventHandler(this.cb_art_Enter);
            // 
            // Modif_Art
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 216);
            this.Controls.Add(this.cb_art);
            this.Controls.Add(this.botonlimpiar);
            this.Controls.Add(this.lb_error3);
            this.Controls.Add(this.lb_error2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonmodif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.tb_nombre);
            this.Name = "Modif_Art";
            this.Text = "Modif_Art";
            this.Load += new System.EventHandler(this.Modif_Art_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonmodif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_error2;
        private System.Windows.Forms.Label lb_error3;
        private System.Windows.Forms.Button botonlimpiar;
        private System.Windows.Forms.ComboBox cb_art;
    }
}