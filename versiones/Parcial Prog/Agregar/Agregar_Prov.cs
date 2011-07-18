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
    public partial class Agregar_Prov : Form
    {
        public Agregar_Prov()
        {
            InitializeComponent();
        }

        private void agregar_prov()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@cuit", tb_cuit.Text);
            comandosql.Parameters.AddWithValue("@nombre", tb_nombre.Text);
            comandosql.Parameters.AddWithValue("@telefono", tb_telefono.Text);
            comandosql.Parameters.AddWithValue("@web", tb_web.Text);
            comandosql.Parameters.AddWithValue("@mail", tb_mail.Text);
            comandosql.Parameters.AddWithValue("@direccion", tb_direccion.Text);
            comandosql.Parameters.AddWithValue("@ciudad", tb_ciudad.Text);
            comandosql.Parameters.AddWithValue("@provincia", tb_provincia.Text);
            comandosql.CommandText = "Ing_Prov";
            comandosql.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Proveedornuevo");
            adaptador.Dispose();
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
            try
            {
                agregar_prov();
                MessageBox.Show("Su proveedor se ingreso correctamente");
            }
            catch
            {
                MessageBox.Show("Su proveedor no pudo ingresarse, intentelo nuevamente");
            }

            tb_cuit.Text = null;
            tb_nombre.Text = null;
            tb_telefono.Text = null;
            tb_web.Text = null;
            tb_mail.Text = null;
            tb_direccion.Text = null;
            tb_ciudad.Text = null;
            tb_provincia.Text = null;
            tb_cuit.Focus();         
        } 
    }
}
