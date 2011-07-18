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
    public partial class Agregar_Artxprov : Form
    {
        public Agregar_Artxprov()
        {
            InitializeComponent();
        }

        private void buscar_art()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            string consulta = "select * from Articulos";
            SqlConnection conexion = new SqlConnection(rutaSql);
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "Articulosbuscados");
            if (dataset.Tables["Articulosbuscados"].Rows.Count > 0)
            {
                cb_art.DataSource = dataset.Tables["Articulosbuscados"];
                cb_art.DisplayMember = "idarticulo";
            }
            adaptador.Dispose();
        }

        private void buscar_prov()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            string consulta = "select * from Proveedores";
            SqlConnection conexion = new SqlConnection(rutaSql);
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "Proveedoresbuscados");
            if (dataset.Tables["Proveedoresbuscados"].Rows.Count > 0)
            {
                cb_prov.DataSource = dataset.Tables["Proveedoresbuscados"];
                cb_prov.DisplayMember = "idproveedor";
            }
            adaptador.Dispose();
        }

        private void ingresar_artxprov()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@idarticulo", int.Parse(cb_art.Text.Trim()));
            comandosql.Parameters.AddWithValue("@idproveedor",int.Parse(cb_prov.Text.Trim()));
            comandosql.CommandText = "Ing_ArticulosxProv";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Artxprovnuevo");
            adaptador.Dispose();
        }

        private void Agregar_Artxprov_Load(object sender, EventArgs e)
        {
            buscar_art();
            buscar_prov();
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
            ingresar_artxprov();
            MessageBox.Show("Su proveedor se ingreso correctamente");
            cb_art.Text = null;
            cb_prov.Text = null;
            cb_art.Focus();
        }
    }
}
