namespace WindowsFormsApplication1
{
    partial class Venta
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idart = new System.Windows.Forms.TextBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.tb_nfactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_errorid = new System.Windows.Forms.Label();
            this.lb_errorcant = new System.Windows.Forms.Label();
            this.botonborrar = new System.Windows.Forms.Button();
            this.lb_nombreart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // tb_idart
            // 
            this.tb_idart.Location = new System.Drawing.Point(24, 32);
            this.tb_idart.Name = "tb_idart";
            this.tb_idart.Size = new System.Drawing.Size(100, 20);
            this.tb_idart.TabIndex = 2;
            this.tb_idart.TextChanged += new System.EventHandler(this.tb_idart_TextChanged);
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(146, 32);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(100, 20);
            this.tb_cantidad.TabIndex = 3;
            this.tb_cantidad.TextChanged += new System.EventHandler(this.tb_cantidad_TextChanged);
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(292, 30);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 5;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha";
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(292, 493);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 8;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(27, 450);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 10;
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.AllowUserToResizeColumns = false;
            this.Grilla.AllowUserToResizeRows = false;
            this.Grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grilla.Location = new System.Drawing.Point(27, 116);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(343, 165);
            this.Grilla.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total:";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(322, 295);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(13, 13);
            this.lb_total.TabIndex = 13;
            this.lb_total.Text = "0";
            // 
            // tb_nfactura
            // 
            this.tb_nfactura.Location = new System.Drawing.Point(131, 367);
            this.tb_nfactura.Name = "tb_nfactura";
            this.tb_nfactura.ReadOnly = true;
            this.tb_nfactura.Size = new System.Drawing.Size(100, 20);
            this.tb_nfactura.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numero de Factura:";
            // 
            // lb_errorid
            // 
            this.lb_errorid.AutoSize = true;
            this.lb_errorid.Location = new System.Drawing.Point(24, 55);
            this.lb_errorid.Name = "lb_errorid";
            this.lb_errorid.Size = new System.Drawing.Size(35, 13);
            this.lb_errorid.TabIndex = 16;
            this.lb_errorid.Text = "label6";
            // 
            // lb_errorcant
            // 
            this.lb_errorcant.AutoSize = true;
            this.lb_errorcant.Location = new System.Drawing.Point(143, 55);
            this.lb_errorcant.Name = "lb_errorcant";
            this.lb_errorcant.Size = new System.Drawing.Size(35, 13);
            this.lb_errorcant.TabIndex = 17;
            this.lb_errorcant.Text = "label7";
            // 
            // botonborrar
            // 
            this.botonborrar.Location = new System.Drawing.Point(24, 324);
            this.botonborrar.Name = "botonborrar";
            this.botonborrar.Size = new System.Drawing.Size(75, 23);
            this.botonborrar.TabIndex = 18;
            this.botonborrar.Text = "Borrar";
            this.botonborrar.UseVisualStyleBackColor = true;
            this.botonborrar.Click += new System.EventHandler(this.botonborrar_Click);
            // 
            // lb_nombreart
            // 
            this.lb_nombreart.AutoSize = true;
            this.lb_nombreart.Location = new System.Drawing.Point(24, 84);
            this.lb_nombreart.Name = "lb_nombreart";
            this.lb_nombreart.Size = new System.Drawing.Size(35, 13);
            this.lb_nombreart.TabIndex = 19;
            this.lb_nombreart.Text = "label6";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.lb_nombreart);
            this.Controls.Add(this.botonborrar);
            this.Controls.Add(this.lb_errorcant);
            this.Controls.Add(this.lb_errorid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nfactura);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.tb_idart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Venta_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idart;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox tb_nfactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_errorid;
        private System.Windows.Forms.Label lb_errorcant;
        private System.Windows.Forms.Button botonborrar;
        private System.Windows.Forms.Label lb_nombreart;
    }
}