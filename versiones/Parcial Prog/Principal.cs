using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {   
        string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
        string ConsultaSql = null;
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        DataSet dataset;
        SqlCommand comandosql;
        DataGridView Grilla, Grilla2, Grilla3, Grilla4;
        TabPage pest_proveedores, pest_factura;

        public Principal()
        {
            InitializeComponent();
        }

        private void ingresar_artxprov(int a, int b)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@idarticulo", a);
            comandosql.Parameters.AddWithValue("@idproveedor", b);
            comandosql.CommandText = "Ing_ArticulosxProv";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Artxprovnuevo");
            adaptador.Dispose();
        }

        /// <summary>
        /// Crea una nueva pestaña
        /// </summary>
        /// <param name="a">Texto que se mostrara como titulo de la pestaña</param>
        public TabPage crear_pestaña(string a)
        {
            TabPage nueva_pest = new TabPage();
            nueva_pest.Name = a;
            nueva_pest.Location = new System.Drawing.Point(4, 22);
            nueva_pest.Padding = new System.Windows.Forms.Padding(3);
            nueva_pest.Size = new System.Drawing.Size(752, 400);
            nueva_pest.Text = a;
            return nueva_pest;
        }

        /// <summary>
        /// Crea una nueva grilla
        /// </summary>
        /// <returns>Devuelve una grilla adaptada para la pestaña</returns>
        public DataGridView crear_grilla(bool a)
        {
            DataGridView nueva_grilla = new DataGridView();
            nueva_grilla.AllowUserToAddRows = false;
            nueva_grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            nueva_grilla.Location = new System.Drawing.Point(3, 3);
            nueva_grilla.Name = "Grilla3";
            nueva_grilla.Size = new System.Drawing.Size(746, 394);
            //nueva_grilla.Enabled = false;
            nueva_grilla.AllowUserToAddRows = false;
            nueva_grilla.AllowUserToDeleteRows = false;
            nueva_grilla.AllowUserToResizeColumns = false;
            nueva_grilla.AllowUserToResizeRows = false;
            nueva_grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            nueva_grilla.ReadOnly = true;
            if(a)
            nueva_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            return nueva_grilla;
        }

       /// <summary>
       /// Crea la consulta, y carga la tabla en una matriz
       /// </summary>
       /// <param name="a">Nombre de la Tabla</param>
        public void crear_conexion(string a)
        {
            string consulta = ConsultaSql += a;
            //MessageBox.Show(consulta);
            adaptador = new SqlDataAdapter(consulta, conexion);
            dataset = new DataSet();
            adaptador.Fill(dataset,a);         
        }

        /// <summary>
        /// Una vez realizada la consulta, muestra el resultado en la grilla
        /// </summary>
        /// <param name="a">Consulta</param>
        /// <param name="b">Nombre de la Tabla</param>
        /// <param name="c">Nombre de la Grilla</param>
        public void Ejecutar_consulta(string a, string b, DataGridView c)
        {
            ConsultaSql = a;
            crear_conexion(b);
            c.DataSource = dataset.Tables[b];
            adaptador.Dispose();
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado "Buscarxnombre", que busca los articulos
        /// </summary>
        public void Buscar_codigoxnombre()
        {
            textBox_codigo.Text = null;
            comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@nombre", textBox_nombre.Text.TrimEnd().TrimStart());
            comandosql.Parameters.AddWithValue("@marca", textBox_marca.Text.TrimEnd().TrimStart());
            comandosql.CommandText = "Buscarxnombre";
            comandosql.CommandType = CommandType.StoredProcedure;
            adaptador = new SqlDataAdapter(comandosql);
            dataset.Clear();
            adaptador.Fill(dataset, "Articulosbuscados");
            Grilla.DataSource = dataset.Tables["Articulosbuscados"];
            adaptador.Dispose();
            if (Grilla.Rows.Count != 0)
            {
                if (Grilla.Rows[0].Cells[3].Value != null)
                    etiqueta_monto.Text = float.Parse(Grilla.Rows[0].Cells[3].Value.ToString()).ToString("c");
            }
            else etiqueta_monto.Text = null;
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado para buscar por codigo, tanto articulo como proveedor
        /// </summary>
        /// <param name="a">Nombre del procedimiento</param>
        /// <param name="b">Nombre de la tabla en dataset</param>
        /// <param name="c">Grilla en donde sera mostrado</param>
        public void Buscarxcod(string a, string b, DataGridView c)
        {
            textBox_nombre.Text = null;        
            comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", textBox_codigo.Text);
            comandosql.CommandText = a;
            comandosql.CommandType = CommandType.StoredProcedure;
            adaptador = new SqlDataAdapter(comandosql);
            dataset.Clear();
            adaptador.Fill(dataset, b);
            c.DataSource = dataset.Tables[b];
            adaptador.Dispose();
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado "Buscarxprovnombre", que busca los proveedores
        /// </summary>
        public void Buscar_provxnombre()
        {
            textBox_codigo.Text = null;
            comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@nombre", textBox_nombre.Text.TrimEnd().TrimStart());
            comandosql.CommandText = "BuscarProvxnombre";
            comandosql.CommandType = CommandType.StoredProcedure;
            adaptador = new SqlDataAdapter(comandosql);
            dataset.Clear();
            adaptador.Fill(dataset, "Proveedoresbuscados");
            Grilla2.DataSource = dataset.Tables["Proveedoresbuscados"];
            adaptador.Dispose(); 
        }

        private void innerjoinventas()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            string consulta = "select Factura.idfactura, Articulos.nombre, Articulos.marca, DetalleFactura.cantidad, subtotal = DetalleFactura.cantidad * Articulos.precio, Factura.total from (Factura INNER JOIN DetalleFactura on Factura.idfactura = DetalleFactura.idfactura) INNER JOIN Articulos ON DetalleFactura.idarticulo = Articulos.idarticulo";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "JoinVentas");
            Grilla2.DataSource = dataset.Tables["JoinVentas"];
        }

        /// <summary>
        /// Realiza un Select * de ambas tablas, las cuales muestran todo su contenido
        /// </summary>
        public void mostrar_grillas_completas()
        {
            Ejecutar_consulta("select * from ", "Articulos", Grilla);
            innerjoinventas();
        }

       

        private void Principal_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(rutaSql);
            
            Splash splash = new Splash();
            splash.ShowDialog();
            Login login = new Login();
            this.Hide();//Oculta esta ventana
            login.ShowDialog();//Muestra la ventana de Login

            if (Funciones.cerrar)
                this.Close();

            textBox_codigo.Focus();

            Grilla = crear_grilla(true);
            tabControl1.TabPages[0].Controls.Add(Grilla);
                        
            Grilla2 = crear_grilla(false);
            tabControl1.TabPages[1].Controls.Add(Grilla2);

            mostrar_grillas_completas();
            try
            { Grilla.Columns["precio"].DefaultCellStyle.Format = "c"; }
            catch { }
            conexion.Open();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonclosetab_Click(object sender, EventArgs e)
        {
            if ((tabControl1.SelectedTab != pest_articulos) && (tabControl1.SelectedTab != pest_ventas))
            {
                if(tabControl1.SelectedTab == tabControl1.TabPages["Facturas"])
                    articulosToolStripMenuItem.Enabled = true;
                else if(tabControl1.SelectedTab == tabControl1.TabPages["Proveedores"])
                    proveedoresToolStripMenuItem.Enabled = true;
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pest_proveedores = crear_pestaña("Proveedores");
            tabControl1.Controls.Add(pest_proveedores);
            Grilla3 = crear_grilla(false);           
            tabControl1.TabPages["Proveedores"].Controls.Add(Grilla3);
            Ejecutar_consulta("select * from ", "Proveedores", Grilla3);         
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            proveedoresToolStripMenuItem.Enabled = false;
        }

        private void Grilla4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleFactura detalle = new DetalleFactura(Grilla4["idfactura", Grilla4.SelectedCells[0].RowIndex].Value.ToString().Trim(), Grilla4["fecha", Grilla4.SelectedCells[0].RowIndex].Value.ToString().Trim(), Grilla4["total", Grilla4.SelectedCells[0].RowIndex].Value.ToString().Trim());
            detalle.ShowDialog();
            
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pest_factura = crear_pestaña("Facturas");
            tabControl1.Controls.Add(pest_factura);
            Grilla4 = crear_grilla(true);
            tabControl1.TabPages["Facturas"].Controls.Add(Grilla4);
            Ejecutar_consulta("select * from ", "Factura", Grilla4);
            Grilla4.Columns["total"].DefaultCellStyle.Format = "c";
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            articulosToolStripMenuItem.Enabled = false;
            Grilla4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla4_CellDoubleClick);
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Art Agregar_articulo = new Agregar_Art();
            Agregar_articulo.ShowDialog();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Prov Agregar_Proveedor = new Agregar_Prov();
            Agregar_Proveedor.ShowDialog();
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBox_nombre.Text.Length+textBox_marca.Text.Length != 0)
            {
                if (tabControl1.SelectedTab == pest_articulos)
                {
                    Buscar_codigoxnombre();
                }
                else if (tabControl1.SelectedTab == pest_proveedores)
                {
                    Buscar_provxnombre();
                }
            }
            else
            {
                mostrar_grillas_completas();
                etiqueta_monto.Text = null;               
            }
            
        }

        private void textBox_codigo_TextChanged(object sender, EventArgs e)
        {
            if (textBox_codigo.Text.Length != 0)
            {
                lb_error.Text = null;
                if (Funciones.validacion_num(textBox_codigo.Text))
                {
                    if (tabControl1.SelectedTab == pest_articulos)
                    {
                        
                        Buscarxcod("Buscarxcod", "Articulosbuscados", Grilla);
                        if (Grilla.Rows.Count != 0)
                            if (Grilla.Rows[0].Cells[3].Value != null)
                                etiqueta_monto.Text = float.Parse(Grilla.Rows[0].Cells[3].Value.ToString()).ToString("c");
                       
                    }
                    else if (tabControl1.SelectedTab == pest_ventas)
                    {
                        Buscarxcod("Buscarprovxcod", "Proveedoresbuscados", Grilla2);
                    }
                }
                else lb_error.Text = "Ingrese un dato numerico";
            }
            else
            {
                lb_error.Text = null;
                etiqueta_monto.Text = null;
                Ejecutar_consulta("select * from ", "Articulos", Grilla);
            }
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            mostrar_grillas_completas();
            try { Ejecutar_consulta("select * from ", "Factura", Grilla4); }
            catch { }
            try { Ejecutar_consulta("select * from ", "Proveedores", Grilla3); }
            catch { }
        }

        private void textBox_marca_TextChanged(object sender, EventArgs e)
        {
            if (textBox_nombre.Text.Length + textBox_marca.Text.Length != 0)
            {
                Buscar_codigoxnombre();
            }
            else
            {
                mostrar_grillas_completas();
                etiqueta_monto.Text = null;
            }
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            textBox_codigo.Text = null;
            textBox_nombre.Text = null;
            textBox_marca.Text = null;
            mostrar_grillas_completas();
            if (tabControl1.SelectedTab == pest_articulos)
            {
                etiquet_marca.Show();
                textBox_marca.Show();
                etiqueta_precio.Show();
                etiqueta_monto.Show();
            }
            else
            {
                etiquet_marca.Hide();
                textBox_marca.Hide();
                etiqueta_precio.Hide();
                etiqueta_monto.Hide();
            }
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Usuario agregar_usuario = new Agregar_Usuario();
            agregar_usuario.ShowDialog();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modif_Art modifart = new Modif_Art();
            modifart.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modif_Proveedor modifprov = new Modif_Proveedor();
            modifprov.ShowDialog();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(this);
            venta.Show();
            realizarVentaToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;

        }

        private void articuloPorProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Artxprov agregar_artxprov = new Agregar_Artxprov();
            agregar_artxprov.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modif_Pass modifpass = new Modif_Pass();
            modifpass.ShowDialog();
        }

        private void puntoDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoPedido punto_pedido = new PuntoPedido();
            punto_pedido.ShowDialog(); 
        }

    }
}
