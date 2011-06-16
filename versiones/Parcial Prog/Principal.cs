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
        string con_mostrar = "select * from ";//Utilizada para armar una consulta para mostrar datos
        string con_insert = "insert into ";//Utilizada para armar una consulta para agregar datos
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        DataSet dataset;


        public Principal()
        {
            InitializeComponent();
        }

       /// <summary>
       /// Funcion que crea la consulta, y carga la tabla en una matriz
       /// </summary>
       /// <param name="a">Tipo de consulta</param>
       /// <param name="b">Datos a agregar en la consulta</param>
       /// <param name="c">Nombre de la Tabla</param>
        public void crear_conexion(string a,string b,string c)
        {
            string consulta;
            consulta = a += b;
            conexion = new SqlConnection(rutaSql);
            adaptador = new SqlDataAdapter(consulta, conexion);
            dataset = new DataSet();
            adaptador.Fill(dataset,c);            
        }

        /// <summary>
        /// Una vez realizada la consulta, muestra el resultado en la grilla
        /// </summary>
        /// <param name="Abrir_conexion">True cuando se requiere abrir la conexion, False cuando solamente se desea mostrar</param>
        /// <param name="a">Tipo de consulta</param>
        /// <param name="b">Datos a agregar en la consulta</param>
        /// <param name="c">Nombre de la Tabla</param>
        public void Ejecutar_consulta(bool Abrir_conexion,string a,string b,string c)
        {
            crear_conexion(a, b, c);
            if (Abrir_conexion) conexion.Open();
            Grilla.DataSource = dataset.Tables[c];
            adaptador.Dispose();
        }
        
        private void Principal_Load(object sender, EventArgs e)
        {            
            this.Hide();//Oculta esta ventana
            login.ShowDialog();//Muestra la ventana de Login
            Ejecutar_consulta(true, con_mostrar, "Loggear", "Loggear");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAcept_Click(object sender, EventArgs e)
        {

            dataset.Clear();
            Ejecutar_consulta(false, con_insert, "Loggear(usuario,pass) values('" + textBox1.Text + "','" + textBox2.Text + "')", "Loggear");
            Ejecutar_consulta(false, con_mostrar, "Loggear", "Loggear");
        }
    }
}
