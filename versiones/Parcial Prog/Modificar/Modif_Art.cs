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
    public partial class Modif_Art : Form
    {
        public Modif_Art()
        {
            InitializeComponent();
        }

        private bool c = false;

        public static bool validacion_num(string num)
        {
            try
            {
                float.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void buscar_art_cb()
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

        private void habilitar_botones(bool a)
        {
            if (a)
            {
                tb_nombre.Enabled = true;
                tb_marca.Enabled = true;
                tb_precio.Enabled = true;
                tb_stock.Enabled = true;
                botonmodif.Enabled = true;
                botonlimpiar.Enabled = true;
            }
            else
            {
                tb_nombre.Enabled = false;
                tb_marca.Enabled = false;
                tb_precio.Enabled = false;
                tb_stock.Enabled = false;
                botonmodif.Enabled = false;
                botonlimpiar.Enabled = false;
            }
        }

        private void limpiar_txbox()
        {
            tb_nombre.Text = null;
            tb_marca.Text = null;
            tb_precio.Text = null;
            tb_stock.Text = null;
        }

        private bool buscar_art()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", cb_art.Text.Trim());
            comandosql.CommandText = "Buscarxcod";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset,"Artbuscado");
            DataGridView Grilla = new DataGridView();
            Grilla.DataSource = dataset.Tables["Artbuscado"];
            this.Controls.Add(Grilla);
            Grilla.Hide();
            if (Grilla.Rows.Count-1 != 0)
            {
                tb_nombre.Text = Grilla.Rows[0].Cells[1].Value.ToString().Trim();
                tb_marca.Text = Grilla.Rows[0].Cells[2].Value.ToString().Trim();
                tb_precio.Text = float.Parse(Grilla.Rows[0].Cells[3].Value.ToString().Trim()).ToString();
                tb_stock.Text = Grilla.Rows[0].Cells[4].Value.ToString().Trim();
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
            comandosql.Parameters.AddWithValue("@codigo", cb_art.Text);
            comandosql.Parameters.AddWithValue("@nombre", tb_nombre.Text);
            comandosql.Parameters.AddWithValue("@marca", tb_marca.Text);
            comandosql.Parameters.AddWithValue("@precio", float.Parse(tb_precio.Text));
            comandosql.Parameters.AddWithValue("@stock", int.Parse(tb_stock.Text));
            comandosql.CommandText = "Modif_Art";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Artmodif");
        }

        private void Modif_Art_Load(object sender, EventArgs e)
        {
            buscar_art_cb();
            lb_error2.Text = null;
            lb_error3.Text = null;
            cb_art.Focus();
            habilitar_botones(false);
        }

        private void tb_precio_TextChanged(object sender, EventArgs e)
        {
            if (tb_precio.Text.Length != 0)
            {
                if (validacion_num(tb_precio.Text))
                {
                    lb_error2.Text = null;
                }
                else lb_error2.Text = "Numero";
            }
            else
            {
                lb_error2.Text = null;
            }
        }

        private void tb_stock_TextChanged(object sender, EventArgs e)
        {
            if (tb_stock.Text.Length != 0)
            {
                if (validacion_num(tb_stock.Text))
                {
                    lb_error3.Text = null;
                }
                else lb_error3.Text = "Numero";
            }
            else
            {
                lb_error3.Text = null;
            }
        }

        private void botonmodif_Click(object sender, EventArgs e)
        {
            Realizar_Update();
            MessageBox.Show("Su Articulo se modifico con exito");
            habilitar_botones(false);
            cb_art.Text = null;
            cb_art.Focus();
        }

        private void tb_id_Leave(object sender, EventArgs e)
        {
            botonlimpiar.Enabled = true;
            botonmodif.Enabled = true;
        }

        private void botonlimpiar_Click(object sender, EventArgs e)
        {
            cb_art.Text = null;
            habilitar_botones(false);
            limpiar_txbox();
            cb_art.Focus();
        }

        private void tb_id_Enter(object sender, EventArgs e)
        {
            botonlimpiar.Enabled = false;
        }

        private void lb_error2_TextChanged(object sender, EventArgs e)
        {
            if (lb_error2.Text.Length != 0)
                botonmodif.Enabled = false;
            else botonmodif.Enabled = true;
        }

        private void lb_error3_TextChanged(object sender, EventArgs e)
        {
            if (lb_error3.Text.Length != 0)
                botonmodif.Enabled = false;
            else botonmodif.Enabled = true;
        }

        private void lb_error1_TextChanged(object sender, EventArgs e)
        {
            if (lb_error3.Text != null)
            {
                habilitar_botones(false);
            }
        }

        private void cb_art_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c)
            {
                habilitar_botones(true);
                if (buscar_art())
                {
                    habilitar_botones(true);
                }
                else
                {
                    habilitar_botones(false);
                }
            }
        }

        private void cb_art_Enter(object sender, EventArgs e)
        {
            c = true;   
        }
    }
}
