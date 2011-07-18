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
            this.components = new System.ComponentModel.Container();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pest_articulos = new System.Windows.Forms.TabPage();
            this.pest_ventas = new System.Windows.Forms.TabPage();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloPorProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiqueta_codigo = new System.Windows.Forms.Label();
            this.etiqueta_nombre = new System.Windows.Forms.Label();
            this.etiqueta_precio = new System.Windows.Forms.Label();
            this.etiqueta_monto = new System.Windows.Forms.Label();
            this.botonclosetab = new System.Windows.Forms.Button();
            this.botonactualizar = new System.Windows.Forms.Button();
            this.textBox_marca = new System.Windows.Forms.TextBox();
            this.etiquet_marca = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(12, 43);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(100, 20);
            this.textBox_codigo.TabIndex = 0;
            this.textBox_codigo.TextChanged += new System.EventHandler(this.textBox_codigo_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pest_articulos);
            this.tabControl1.Controls.Add(this.pest_ventas);
            this.tabControl1.Location = new System.Drawing.Point(12, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 426);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // pest_articulos
            // 
            this.pest_articulos.Location = new System.Drawing.Point(4, 22);
            this.pest_articulos.Name = "pest_articulos";
            this.pest_articulos.Padding = new System.Windows.Forms.Padding(3);
            this.pest_articulos.Size = new System.Drawing.Size(752, 400);
            this.pest_articulos.TabIndex = 0;
            this.pest_articulos.Text = "Productos";
            this.pest_articulos.UseVisualStyleBackColor = true;
            // 
            // pest_ventas
            // 
            this.pest_ventas.Location = new System.Drawing.Point(4, 22);
            this.pest_ventas.Name = "pest_ventas";
            this.pest_ventas.Padding = new System.Windows.Forms.Padding(3);
            this.pest_ventas.Size = new System.Drawing.Size(752, 400);
            this.pest_ventas.TabIndex = 1;
            this.pest_ventas.Text = "Ventas";
            this.pest_ventas.UseVisualStyleBackColor = true;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(139, 43);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 1;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
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
            this.realizarVentaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.realizarVentaToolStripMenuItem.Text = "Realizar Venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem1,
            this.proveedoresToolStripMenuItem1,
            this.articuloPorProveedorToolStripMenuItem1});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // articulosToolStripMenuItem1
            // 
            this.articulosToolStripMenuItem1.Name = "articulosToolStripMenuItem1";
            this.articulosToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.articulosToolStripMenuItem1.Text = "Articulos";
            this.articulosToolStripMenuItem1.Click += new System.EventHandler(this.articulosToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // articuloPorProveedorToolStripMenuItem1
            // 
            this.articuloPorProveedorToolStripMenuItem1.Name = "articuloPorProveedorToolStripMenuItem1";
            this.articuloPorProveedorToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.articuloPorProveedorToolStripMenuItem1.Text = "Articulo por Proveedor";
            this.articuloPorProveedorToolStripMenuItem1.Click += new System.EventHandler(this.articuloPorProveedorToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.articuloToolStripMenuItem.Text = "Articulo";
            this.articuloToolStripMenuItem.Click += new System.EventHandler(this.articuloToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.puntoDePedidoToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.articulosToolStripMenuItem.Text = "Facturas";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // puntoDePedidoToolStripMenuItem
            // 
            this.puntoDePedidoToolStripMenuItem.Name = "puntoDePedidoToolStripMenuItem";
            this.puntoDePedidoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.puntoDePedidoToolStripMenuItem.Text = "Punto de Pedido";
            this.puntoDePedidoToolStripMenuItem.Click += new System.EventHandler(this.puntoDePedidoToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
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
            this.etiqueta_nombre.Location = new System.Drawing.Point(139, 27);
            this.etiqueta_nombre.Name = "etiqueta_nombre";
            this.etiqueta_nombre.Size = new System.Drawing.Size(44, 13);
            this.etiqueta_nombre.TabIndex = 7;
            this.etiqueta_nombre.Text = "Nombre";
            // 
            // etiqueta_precio
            // 
            this.etiqueta_precio.AutoSize = true;
            this.etiqueta_precio.Location = new System.Drawing.Point(379, 46);
            this.etiqueta_precio.Name = "etiqueta_precio";
            this.etiqueta_precio.Size = new System.Drawing.Size(40, 13);
            this.etiqueta_precio.TabIndex = 8;
            this.etiqueta_precio.Text = "Precio:";
            // 
            // etiqueta_monto
            // 
            this.etiqueta_monto.AutoSize = true;
            this.etiqueta_monto.Location = new System.Drawing.Point(434, 46);
            this.etiqueta_monto.Name = "etiqueta_monto";
            this.etiqueta_monto.Size = new System.Drawing.Size(0, 13);
            this.etiqueta_monto.TabIndex = 9;
            // 
            // botonclosetab
            // 
            this.botonclosetab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonclosetab.Location = new System.Drawing.Point(738, 106);
            this.botonclosetab.Name = "botonclosetab";
            this.botonclosetab.Size = new System.Drawing.Size(23, 23);
            this.botonclosetab.TabIndex = 10;
            this.botonclosetab.Text = "X";
            this.botonclosetab.UseVisualStyleBackColor = true;
            this.botonclosetab.Click += new System.EventHandler(this.botonclosetab_Click);
            // 
            // botonactualizar
            // 
            this.botonactualizar.Location = new System.Drawing.Point(15, 95);
            this.botonactualizar.Name = "botonactualizar";
            this.botonactualizar.Size = new System.Drawing.Size(79, 23);
            this.botonactualizar.TabIndex = 11;
            this.botonactualizar.Text = "Actualizar";
            this.botonactualizar.UseVisualStyleBackColor = true;
            this.botonactualizar.Click += new System.EventHandler(this.botonactualizar_Click);
            // 
            // textBox_marca
            // 
            this.textBox_marca.Location = new System.Drawing.Point(262, 43);
            this.textBox_marca.Name = "textBox_marca";
            this.textBox_marca.Size = new System.Drawing.Size(100, 20);
            this.textBox_marca.TabIndex = 2;
            this.textBox_marca.TextChanged += new System.EventHandler(this.textBox_marca_TextChanged);
            // 
            // etiquet_marca
            // 
            this.etiquet_marca.AutoSize = true;
            this.etiquet_marca.Location = new System.Drawing.Point(259, 27);
            this.etiquet_marca.Name = "etiquet_marca";
            this.etiquet_marca.Size = new System.Drawing.Size(37, 13);
            this.etiquet_marca.TabIndex = 12;
            this.etiquet_marca.Text = "Marca";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Location = new System.Drawing.Point(12, 66);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 13);
            this.lb_error.TabIndex = 13;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.etiquet_marca);
            this.Controls.Add(this.textBox_marca);
            this.Controls.Add(this.botonactualizar);
            this.Controls.Add(this.botonclosetab);
            this.Controls.Add(this.etiqueta_monto);
            this.Controls.Add(this.etiqueta_precio);
            this.Controls.Add(this.etiqueta_nombre);
            this.Controls.Add(this.etiqueta_codigo);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox_codigo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pest_articulos;
        private System.Windows.Forms.TabPage pest_ventas;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.Label etiqueta_codigo;
        private System.Windows.Forms.Label etiqueta_nombre;
        private System.Windows.Forms.Label etiqueta_precio;
        private System.Windows.Forms.Label etiqueta_monto;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.Button botonclosetab;
        private System.Windows.Forms.Button botonactualizar;
        public System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_marca;
        private System.Windows.Forms.Label etiquet_marca;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloPorProveedorToolStripMenuItem1;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDePedidoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

