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
    public partial class Modif_Pass : Form
    {
        public Modif_Pass()
        {
            InitializeComponent();
        }

        private bool buscar_user(string user, string pass)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            string consulta = "select * from Loggear where Loggear.usuario = '" + user + "' AND Loggear.pass = '" + pass + "'";
            SqlConnection conexion = new SqlConnection(rutaSql);
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "Userbuscado");
            DataGridView Grilla = new DataGridView();
            Grilla.DataSource = dataset.Tables["Usertbuscado"];
            this.Controls.Add(Grilla);
            if (Grilla.Rows.Count - 1 != 0)
            {
                this.Controls.Remove(Grilla);
                return true;
            }
            else 
            {
                this.Controls.Remove(Grilla);
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
            comandosql.Parameters.AddWithValue("@user", tb_user.Text);
            comandosql.Parameters.AddWithValue("@pass", tb_passnueva.Text);
            comandosql.CommandText = "Modif_Pass";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Passmodif");
        }

        private void botonaceptar_Click(object sender, EventArgs e)
        {
            if (buscar_user(tb_user.Text.Trim(), tb_pass.Text.Trim()))
            {
                Realizar_Update();
                MessageBox.Show("Se modifico correctamente");
            }
        }
    }
}
