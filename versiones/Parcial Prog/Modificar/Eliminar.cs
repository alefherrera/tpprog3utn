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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private bool validar = false;

        private void eliminar_art()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", int.Parse(cb_id.Text));
            comandosql.CommandText = "Elim_Art";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Artelim");
        }

        private void eliminar_prov()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", int.Parse(cb_id.Text));
            comandosql.CommandText = "Elim_Prov";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Provelim");
        }

        private void eliminar_artxprov(int a)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            switch (a)
            {
                case 1:
                    comandosql.Parameters.AddWithValue("@verificar", a);
                    comandosql.Parameters.AddWithValue("@codart", int.Parse(cb_id.Text));
                    break;
                case 2:
                    comandosql.Parameters.AddWithValue("@verificar", a);
                    comandosql.Parameters.AddWithValue("@codprov", int.Parse(cb_id.Text));
                    break;
                case 3:
                    comandosql.Parameters.AddWithValue("@verificar", a);
                    comandosql.Parameters.AddWithValue("@codart", int.Parse(cb_id.Text));
                    comandosql.Parameters.AddWithValue("@codprov", int.Parse(cb_artxprov.Text));
                    break;
            }
            comandosql.CommandText = "Elim_Artxprov";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Artxprovelim");
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
                cb_id.DataSource = dataset.Tables["Articulosbuscados"];
                cb_id.DisplayMember = "idarticulo";
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
                cb_id.DataSource = dataset.Tables["Proveedoresbuscados"];
                cb_id.DisplayMember = "idproveedor";
            }
            adaptador.Dispose();
        }

        private void buscar_artxprov(string a)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            string consulta = "select * from ArticulosxProv where ArticulosxProv.idarticulo = "+a;
            SqlConnection conexion = new SqlConnection(rutaSql);
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "Artxprovb");
            if (dataset.Tables["Artxprovb"].Rows.Count > 0)
            {
                cb_artxprov.DataSource = dataset.Tables["Artxprovb"];
                cb_artxprov.DisplayMember = "idproveedor";
            }
            adaptador.Dispose();
        }


        private void Eliminar_Load(object sender, EventArgs e)
        {
            botoneliminar.Enabled = false;
            cb_artxprov.Hide();
            cb_tipo.Items.Add("Articulo");
            cb_tipo.Items.Add("Proveedor");
            cb_tipo.Items.Add("Articulo por Proveedor");
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_tipo.Text)
            {
                case "Articulo":
                    cb_artxprov.Hide();
                    validar = false;
                    buscar_art();
                    break;
                case "Proveedor":
                    cb_artxprov.Hide();
                    validar = false;
                    buscar_prov();
                    break;
                case "Articulo por Proveedor":
                    cb_artxprov.Show();
                    buscar_art();
                    break;
            }
        }

        private void cb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validar)
            {
                if (cb_tipo.Text == "Articulo por Proveedor")
                {
                    buscar_artxprov(cb_id.Text);
                }
                else
                {
                    validar = false;
                    botoneliminar.Enabled = true;
                }
            }
            else botoneliminar.Enabled = false;
        }

        private void cb_id_Enter(object sender, EventArgs e)
        {
            validar = true;
        }

        private void cb_artxprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            botoneliminar.Enabled = true;
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            switch (cb_tipo.Text)
            {
                case "Articulo":
                    eliminar_art();
                    try
                    {
                        eliminar_artxprov(1);
                    }
                    catch
                    {
                        MessageBox.Show("El articulo no existe en art x prov");
                    }
                    MessageBox.Show("Articulos eliminado");
                    break;
                case "Proveedor":
                    eliminar_prov();
                    try
                    {
                        eliminar_artxprov(2);
                    }
                    catch
                    {
                        MessageBox.Show("El articulo no existe en art x prov");                                            
                    }
                    MessageBox.Show("Proveedor eliminado");
                    break;
                case "Articulo por Proveedor":
                    eliminar_artxprov(3);
                    MessageBox.Show("Articulo por proveedor eliminado");
                    break;
            }
            validar = false;
            cb_artxprov.Hide();
            cb_tipo.Text = null;
            cb_id.Text = null;
            cb_artxprov.Text = null;
            cb_tipo.Focus();
            botoneliminar.Enabled = false;
        }

        private void cb_artxprov_TextChanged(object sender, EventArgs e)
        {
            cb_artxprov.Text.Trim();
        }
    }
}
