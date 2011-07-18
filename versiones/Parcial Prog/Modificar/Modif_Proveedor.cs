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
    public partial class Modif_Proveedor : Form
    {
        public Modif_Proveedor()
        {
            InitializeComponent();
        }

        private bool c = false;

        private void habilitar_botones(bool a)
        {
            if (a)
            {
                
                tb_cuit.Enabled = true;
                tb_mail.Enabled = true;
                tb_nombre.Enabled = true;
                tb_direccion.Enabled = true;
                tb_telefono.Enabled = true;
                tb_ciudad.Enabled = true;
                tb_web.Enabled = true;
                tb_provincia.Enabled = true;
                botonmodificar.Enabled = true;
            }
            else
            {
                tb_cuit.Enabled = false;
                tb_mail.Enabled = false;
                tb_nombre.Enabled = false;
                tb_direccion.Enabled = false;
                tb_telefono.Enabled = false;
                tb_ciudad.Enabled = false;
                tb_web.Enabled = false;
                tb_provincia.Enabled = false;
                botonmodificar.Enabled = false;
            }
        }

        private void buscar_prov_cb()
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

        private bool buscar_prov()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", cb_prov.Text.Trim());
            comandosql.CommandText = "BuscarProvxcod";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset,"Provbuscados");
            DataGridView Grilla = new DataGridView();
            Grilla.DataSource = dataset.Tables["Provbuscados"];
            this.Controls.Add(Grilla);
            Grilla.Hide();
            if (Grilla.Rows.Count-1 != 0)
            {
                tb_cuit.Text = Grilla["cuit",0].Value.ToString().Trim();
                tb_mail.Text = Grilla["mail",0].Value.ToString().Trim();
                tb_nombre.Text = Grilla["nombre",0].Value.ToString().Trim();
                tb_direccion.Text = Grilla["direccion",0].Value.ToString().Trim();
                tb_telefono.Text = Grilla["telefono",0].Value.ToString().Trim();
                tb_ciudad.Text = Grilla["ciudad",0].Value.ToString().Trim();
                tb_web.Text = Grilla["web",0].Value.ToString().Trim();
                tb_provincia.Text = Grilla["provincia",0].Value.ToString().Trim();
                this.Controls.Remove(Grilla);
                adaptador.Dispose();
                return true;
            }
            else
            {
                this.Controls.Remove(Grilla);
                adaptador.Dispose();
                return false;
            }
        }

        private void Realizar_Update()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", cb_prov.Text);
            comandosql.Parameters.AddWithValue("@cuit",tb_cuit.Text);
            comandosql.Parameters.AddWithValue("@nombre", tb_nombre.Text);
            comandosql.Parameters.AddWithValue("@telefono", tb_telefono.Text);
            comandosql.Parameters.AddWithValue("@web",tb_web.Text);
            comandosql.Parameters.AddWithValue("@mail",tb_mail.Text);
            comandosql.Parameters.AddWithValue("@direccion",tb_direccion.Text);
            comandosql.Parameters.AddWithValue("@ciudad",tb_ciudad.Text);
            comandosql.Parameters.AddWithValue("@provincia",tb_provincia.Text);
            comandosql.CommandText = "Modif_Prov";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Provmodif");
        }

        private void Modif_Proveedor_Load(object sender, EventArgs e)
        {
            buscar_prov_cb();
            cb_prov.Focus();
            habilitar_botones(false);
        }

        private void cb_prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c)
            {
                habilitar_botones(true);
                if (buscar_prov())
                {
                    habilitar_botones(true);
                }
                else
                {
                    habilitar_botones(false);
                }
            }
        }

        private void cb_prov_Enter(object sender, EventArgs e)
        {
            c = true;   
        }

        private void botonmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                Realizar_Update();
                MessageBox.Show("Su Articulo se modifico con exito");
            }
            catch 
            {
                MessageBox.Show("No se pudo realizar la operacion");
            }
            habilitar_botones(false);
            cb_prov.Text = null;
            cb_prov.Focus();
        }
    }
}
