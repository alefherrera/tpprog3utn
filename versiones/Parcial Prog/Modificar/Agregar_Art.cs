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
    public partial class Agregar_Art : Form
    {
        public Agregar_Art()
        {
            InitializeComponent();
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
                string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
                SqlConnection conexion = new SqlConnection(rutaSql);
                conexion.Open();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = conexion;
                comandosql.Parameters.AddWithValue("@nombre", tb_nombre.Text);
                comandosql.Parameters.AddWithValue("@marca", tb_marca.Text);
                comandosql.Parameters.AddWithValue("@precio", tb_precio.Text);
                comandosql.Parameters.AddWithValue("@stock", tb_stock.Text);
                comandosql.CommandText = "Ing_Art";
                comandosql.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
                DataSet dataset = new DataSet();
                dataset.Clear();
                adaptador.Fill(dataset, "Articulonuevo");
                adaptador.Dispose();

                MessageBox.Show("Su articulo se ingreso correctamente");
                tb_nombre.Text = null;
                tb_marca.Text = null;
                tb_precio.Text = null;
                tb_stock.Text = null;
                tb_nombre.Focus();
        }
    }
}
