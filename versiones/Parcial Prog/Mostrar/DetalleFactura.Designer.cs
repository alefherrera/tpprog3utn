namespace WindowsFormsApplication1
{
    partial class DetalleFactura
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
            this.tb_idfactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fecha = new System.Windows.Forms.TextBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.botonaceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_idfactura
            // 
            this.tb_idfactura.Enabled = false;
            this.tb_idfactura.Location = new System.Drawing.Point(12, 25);
            this.tb_idfactura.Name = "tb_idfactura";
            this.tb_idfactura.Size = new System.Drawing.Size(73, 20);
            this.tb_idfactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // tb_fecha
            // 
            this.tb_fecha.Enabled = false;
            this.tb_fecha.Location = new System.Drawing.Point(187, 25);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.Size = new System.Drawing.Size(64, 20);
            this.tb_fecha.TabIndex = 3;
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(12, 60);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(441, 150);
            this.Grilla.TabIndex = 4;
            // 
            // botonaceptar
            // 
            this.botonaceptar.Location = new System.Drawing.Point(378, 22);
            this.botonaceptar.Name = "botonaceptar";
            this.botonaceptar.Size = new System.Drawing.Size(75, 23);
            this.botonaceptar.TabIndex = 5;
            this.botonaceptar.Text = "Aceptar";
            this.botonaceptar.UseVisualStyleBackColor = true;
            this.botonaceptar.Click += new System.EventHandler(this.botonaceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // tb_total
            // 
            this.tb_total.Enabled = false;
            this.tb_total.Location = new System.Drawing.Point(353, 223);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(100, 20);
            this.tb_total.TabIndex = 7;
            // 
            // DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 259);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonaceptar);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.tb_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_idfactura);
            this.Name = "DetalleFactura";
            this.Text = "DetalleFactura";
            this.Load += new System.EventHandler(this.DetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_idfactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fecha;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button botonaceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_total;
    }
}