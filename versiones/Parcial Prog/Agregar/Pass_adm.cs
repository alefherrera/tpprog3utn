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
    public partial class Pass_adm : Form
    {
        public Pass_adm()
        {
            InitializeComponent();
        }

        private void botonaceptar_Click(object sender, EventArgs e)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@usuario", "admin");
            comandosql.Parameters.AddWithValue("@pass", textBox1.Text);
            comandosql.CommandText = "Ing_Loggear";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Usernuevo");
            adaptador.Dispose();
            MessageBox.Show("Contraseña ingresada correctamente");
            this.Close();
        }
    }
}
