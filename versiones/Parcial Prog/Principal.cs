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
        Login login = new Login();

        string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
        string ConsultaSql = null;
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        DataSet dataset;

        public Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crea una nueva pestaña
        /// </summary>
        /// <param name="a">Texto que se mostrara como titulo de la pestaña</param>
        public void crear_pestaña(string a)
        {
            tabControl1.TabPages.Add(a);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Location = new System.Drawing.Point(4, 22);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Padding = new System.Windows.Forms.Padding(3);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Size = new System.Drawing.Size(752, 400);
        }

        /// <summary>
        /// Crea una nueva grilla
        /// </summary>
        /// <returns>Devuelve una grilla adaptada para la pestaña</returns>
        public DataGridView crear_grilla()
        {
            DataGridView nueva_grilla = new DataGridView();
            nueva_grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            nueva_grilla.Location = new System.Drawing.Point(3, 3);
            nueva_grilla.Name = "Grilla3";
            nueva_grilla.Size = new System.Drawing.Size(746, 394);
            return nueva_grilla;
        }

       /// <summary>
       /// Crea la consulta, y carga la tabla en una matriz
       /// </summary>
       /// <param name="a">Nombre de la Tabla</param>
        public void crear_conexion(string a)
        {
            string consulta = ConsultaSql += a;
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
        

        private void Principal_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(rutaSql);
            this.Hide();//Oculta esta ventana
            login.ShowDialog();//Muestra la ventana de Login

            DataGridView Grilla = crear_grilla();
            tabControl1.TabPages[0].Controls.Add(Grilla);
            Ejecutar_consulta("select * from ", "Articulos", Grilla);
            
            DataGridView Grilla2 = crear_grilla();
            tabControl1.TabPages[1].Controls.Add(Grilla2);
            Ejecutar_consulta("select * from ", "Proveedores", Grilla2);

            conexion.Open();
            Ejecutar_consulta("select * from ", "Articulos", Grilla);
            Ejecutar_consulta("select * from ", "Proveedores", Grilla2);
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
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crear_pestaña("Proveedores");
            DataGridView Grilla3 = crear_grilla();           
            tabControl1.TabPages[tabControl1.TabPages.Count-1].Controls.Add(Grilla3);
            Ejecutar_consulta("select * from ", "Proveedores", Grilla3);

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crear_pestaña("Facturas");
            DataGridView Grilla4 = crear_grilla();
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(Grilla4);
            Ejecutar_consulta("select * from ", "Factura", Grilla4);

        }      
    }
}
