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
    public partial class Agregar_Usuario : Form
    {
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@usuario", tb_user.Text);
            comandosql.Parameters.AddWithValue("@pass", tb_pass.Text);
            comandosql.CommandText = "Ing_Loggear";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Usernuevo");
            adaptador.Dispose();

            MessageBox.Show("Su usuario se ingreso correctamente");
            tb_user.Text = null;
            tb_pass.Text = null;
            tb_admin.Text = null;
            tb_user.Focus();
        }

       

        
    }
}
