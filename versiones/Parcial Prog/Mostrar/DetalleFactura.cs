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
    public partial class DetalleFactura : Form
    {
        private string idfactura,fecha,total;
        public DetalleFactura(string a,string b,string c)
        {
            idfactura = a;
            fecha = b;
            total = c;
            InitializeComponent();
        }

        private void innerjoinventas()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            string consulta = "select Articulos.nombre, Articulos.marca, DetalleFactura.cantidad, subtotal = DetalleFactura.cantidad * Articulos.precio from DetalleFactura INNER JOIN Articulos ON DetalleFactura.idarticulo = Articulos.idarticulo WHERE DetalleFactura.idfactura = '" + idfactura + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "JoinVentas");
            Grilla.DataSource = dataset.Tables["JoinVentas"];
        }

        private void DetalleFactura_Load(object sender, EventArgs e)
        {
            tb_fecha.Text = fecha;
            tb_idfactura.Text = idfactura;
            tb_total.Text = total;
            innerjoinventas();
            Grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.AllowUserToAddRows = false;
            Grilla.AllowUserToDeleteRows = false;
            Grilla.AllowUserToResizeColumns = false;
            Grilla.AllowUserToResizeRows = false;
            Grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            Grilla.ReadOnly = true;
        }

        private void botonaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
