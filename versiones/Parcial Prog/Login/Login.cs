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
    public partial class Login : Form
    {
        public void validacion_log(int a)
        {
            if (tb_user.Text.Length > a)
            {
                MessageBox.Show("Por Favor ingrese un nombre de usuario valido");
                tb_user.Focus();
            }
            else if (tb_pass.Text.Length > a)
            {
                MessageBox.Show("Por Favor ingrese una contraseña valida");
                tb_pass.Focus();
            }
        }
        
        public Login()
        {
            InitializeComponent();
        }

        private void logear_Click(object sender, EventArgs e)
        {            
            validacion_log(9);
            string a = null;
            string b = null;
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@user", tb_user.Text);
            comandosql.CommandText = "Buscarpass";
            comandosql.CommandType = CommandType.StoredProcedure;          
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            SqlParameter sqlreturn = new SqlParameter("@return_value", SqlDbType.Int);
            sqlreturn.Direction = ParameterDirection.ReturnValue;
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Userbuscado");
            adaptador.Dispose();  
            DataGridView Grilla = new DataGridView();
            Grilla.DataSource = dataset.Tables["Userbuscado"];
            this.Controls.Add(Grilla);
            Grilla.Hide();
            if (Grilla.Rows[0].Cells[0].Value != null)
                a = Grilla.Rows[0].Cells[0].Value.ToString();
            if (Grilla.Rows[0].Cells[1].Value != null)
                b = Grilla.Rows[0].Cells[1].Value.ToString().Trim();
            this.Controls.Remove(Grilla);
            if (a == null)
            {
                tb_user.Text = null;
                tb_pass.Text = null;                
                MessageBox.Show("El Usuario no existe");
                tb_user.Focus();
            }
            else if (tb_pass.Text.Trim() == b)
            {
                Funciones.cerrar = false;
                this.Close();
            }
            else
            {
                tb_pass.Text = null;
                tb_pass.Focus();
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}
