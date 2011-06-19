namespace WindowsFormsApplication1
{
    partial class Principal
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
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pest1 = new System.Windows.Forms.TabPage();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Pest2 = new System.Windows.Forms.TabPage();
            this.Grilla2 = new System.Windows.Forms.DataGridView();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiqueta_codigo = new System.Windows.Forms.Label();
            this.etiqueta_nombre = new System.Windows.Forms.Label();
            this.etiqueta_precio = new System.Windows.Forms.Label();
            this.etiqueta_monto = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Pest1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.Pest2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(12, 43);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(100, 20);
            this.textBox_codigo.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pest1);
            this.tabControl1.Controls.Add(this.Pest2);
            this.tabControl1.Location = new System.Drawing.Point(12, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 426);
            this.tabControl1.TabIndex = 2;
           
            // 
            // Pest1
            // 
            this.Pest1.Controls.Add(this.Grilla);
            this.Pest1.Location = new System.Drawing.Point(4, 22);
            this.Pest1.Name = "Pest1";
            this.Pest1.Padding = new System.Windows.Forms.Padding(3);
            this.Pest1.Size = new System.Drawing.Size(752, 400);
            this.Pest1.TabIndex = 0;
            this.Pest1.Text = "Productos";
            this.Pest1.UseVisualStyleBackColor = true;
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grilla.Location = new System.Drawing.Point(3, 3);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(746, 394);
            this.Grilla.TabIndex = 0;
            // 
            // Pest2
            // 
            this.Pest2.Controls.Add(this.Grilla2);
            this.Pest2.Location = new System.Drawing.Point(4, 22);
            this.Pest2.Name = "Pest2";
            this.Pest2.Padding = new System.Windows.Forms.Padding(3);
            this.Pest2.Size = new System.Drawing.Size(752, 400);
            this.Pest2.TabIndex = 1;
            this.Pest2.Text = "Ventas";
            this.Pest2.UseVisualStyleBackColor = true;
            // 
            // Grilla2
            // 
            this.Grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grilla2.Location = new System.Drawing.Point(3, 3);
            this.Grilla2.Name = "Grilla2";
            this.Grilla2.Size = new System.Drawing.Size(746, 394);
            this.Grilla2.TabIndex = 0;
            
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(155, 43);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 3;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(12, 87);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // etiqueta_codigo
            // 
            this.etiqueta_codigo.AutoSize = true;
            this.etiqueta_codigo.Location = new System.Drawing.Point(12, 27);
            this.etiqueta_codigo.Name = "etiqueta_codigo";
            this.etiqueta_codigo.Size = new System.Drawing.Size(40, 13);
            this.etiqueta_codigo.TabIndex = 6;
            this.etiqueta_codigo.Text = "Codigo";
            // 
            // etiqueta_nombre
            // 
            this.etiqueta_nombre.AutoSize = true;
            this.etiqueta_nombre.Location = new System.Drawing.Point(13, 71);
            this.etiqueta_nombre.Name = "etiqueta_nombre";
            this.etiqueta_nombre.Size = new System.Drawing.Size(44, 13);
            this.etiqueta_nombre.TabIndex = 7;
            this.etiqueta_nombre.Text = "Nombre";
            // 
            // etiqueta_precio
            // 
            this.etiqueta_precio.AutoSize = true;
            this.etiqueta_precio.Location = new System.Drawing.Point(468, 87);
            this.etiqueta_precio.Name = "etiqueta_precio";
            this.etiqueta_precio.Size = new System.Drawing.Size(40, 13);
            this.etiqueta_precio.TabIndex = 8;
            this.etiqueta_precio.Text = "Precio:";
            // 
            // etiqueta_monto
            // 
            this.etiqueta_monto.AutoSize = true;
            this.etiqueta_monto.Location = new System.Drawing.Point(509, 87);
            this.etiqueta_monto.Name = "etiqueta_monto";
            this.etiqueta_monto.Size = new System.Drawing.Size(13, 13);
            this.etiqueta_monto.TabIndex = 9;
            this.etiqueta_monto.Text = "$";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.etiqueta_monto);
            this.Controls.Add(this.etiqueta_precio);
            this.Controls.Add(this.etiqueta_nombre);
            this.Controls.Add(this.etiqueta_codigo);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox_codigo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.Pest1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.Pest2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pest1;
        private System.Windows.Forms.TabPage Pest2;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.DataGridView Grilla2;
        private System.Windows.Forms.Label etiqueta_codigo;
        private System.Windows.Forms.Label etiqueta_nombre;
        private System.Windows.Forms.Label etiqueta_precio;
        private System.Windows.Forms.Label etiqueta_monto;
    }
}

