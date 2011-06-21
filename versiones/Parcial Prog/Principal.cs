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

        TabPage nueva_pestaña;
        DataGridView nueva_grilla;


        public Principal()
        {
            InitializeComponent();
        }

       /// <summary>
       /// Funcion que crea la consulta, y carga la tabla en una matriz
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
        /// <param name="a">Nombre de la Grilla</param>
        public void Ejecutar_consulta(string a, string b, DataGridView c)
        {
            ConsultaSql = a;
            crear_conexion(b);
            c.DataSource = dataset.Tables[b];
            adaptador.Dispose();
        }

        public void Crear_pestaña(string a)
        {
            nueva_pestaña = new TabPage(a);
            tabControl1.TabPages.Add(nueva_pestaña);
        }

        public void Crear_grid(string a)
        {
            nueva_grilla = new DataGridView();
            nueva_grilla.Name = a;
        }
        
        private void Principal_Load(object sender, EventArgs e)
        {
            
            //nueva_pestaña = new TabPage("nueva");
            //tabControl1.TabPages.Add(nueva_pestaña);
            conexion = new SqlConnection(rutaSql);
            this.Hide();//Oculta esta ventana
            login.ShowDialog();//Muestra la ventana de Login
            conexion.Open();
            Ejecutar_consulta("select * from ", "Articulos", Grilla);
            Ejecutar_consulta("select * from ", "Proveedores", Grilla2);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void BotonAcept_Click(object sender, EventArgs e)
        {

            dataset.Clear();
            Ejecutar_consulta(false, con_insert, "Loggear(usuario,pass) values('" + textBox1.Text + "','" + textBox2.Text + "')", "Loggear");
            Ejecutar_consulta(false, con_mostrar, "Loggear", "Loggear");
        }*/

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if((tabControl1.SelectedTab != Pest1) && (tabControl1.SelectedTab != Pest2))
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        /*private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Crear_pestaña("Proveedores");
           // Crear_grid("Grilla3");
            //nueva_grilla = new DataGridView();
            //Grilla3 = nueva_grilla.Name.ToString();
            Ejecutar_consulta("select * from ", "Proveedores", nueva_grilla);

        }*/

       
       
        
    }
}
