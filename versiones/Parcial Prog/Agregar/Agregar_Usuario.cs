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

        private string pass_admin = null;

        private bool check_admin()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@user", "admin");
            comandosql.CommandText = "Buscarpass";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Artbuscado");
            DataGridView Grilla = new DataGridView();
            Grilla.DataSource = dataset.Tables["Artbuscado"];
            this.Controls.Add(Grilla);
            Grilla.Hide();
            if (Grilla.Rows.Count - 1 != 0)
            {
                this.Controls.Remove(Grilla);
                adaptador.Dispose();
                pass_admin = Grilla["pass", 0].Value.ToString().Trim();
                return true;
            }
            else
            {
                this.Controls.Remove(Grilla);
                adaptador.Dispose();
                return false;
            }
 
        }

        private void agregar_usuario()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_admin())
            {
                if (pass_admin == tb_admin.Text)
                {
                    try
                    {
                        agregar_usuario();
                        MessageBox.Show("Su usuario se ingreso correctamente");
                    }
                    catch
                    {
                        MessageBox.Show("El usuario no pudo agregarse");
                    }
                    tb_user.Text = null;
                    tb_pass.Text = null;
                    tb_admin.Text = null;
                    tb_user.Focus();
                }
                else MessageBox.Show("Contraseña de Administrador incorrecta");
            }
            else 
            { 
                MessageBox.Show("No existe la cuenta de administrador");
                Pass_adm adm = new Pass_adm();
                adm.ShowDialog();
            }
        }
        
    }
}
