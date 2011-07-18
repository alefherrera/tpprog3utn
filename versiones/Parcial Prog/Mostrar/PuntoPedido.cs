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
    public partial class PuntoPedido : Form
    {
        public PuntoPedido()
        {
            InitializeComponent();
        }

        private void propiedades_grilla(DataGridView a)
        {
            a.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            a.AllowUserToAddRows = false;
            a.AllowUserToDeleteRows = false;
            a.AllowUserToResizeColumns = false;
            a.AllowUserToResizeRows = false;
            a.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            a.ReadOnly = true;
        }

        private void llenar_articulos()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            //string consulta = "select Articulos.nombre, Articulos.marca, Articulos.stock from Articulos INNER JOIN ArticulosxProv ON Articulos.idarticulo = ArticulosxProv.idarticulo WHERE Articulos.stock < 5";
            string consulta = "select Articulos.idarticulo, Articulos.nombre, Articulos.marca, Articulos.stock from Articulos WHERE Articulos.stock < 5";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "Sinstock");
            Grilla.DataSource = dataset.Tables["Sinstock"];
        }

        private void llenar_artxprov(string a)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            string consulta = "select Proveedores.idproveedor, Proveedores.nombre, Proveedores.cuit from (ArticulosxProv INNER JOIN Articulos on Articulos.idarticulo = ArticulosxProv.idarticulo) INNER JOIN Proveedores ON Articulosxprov.idproveedor = Proveedores.idproveedor WHERE Articulos.stock < 5 AND Articulos.idarticulo = "+ int.Parse(a);
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "provs");
            Grilla2.DataSource = dataset.Tables["provs"];
        }

        private void PuntoPedido_Load(object sender, EventArgs e)
        {
            propiedades_grilla(Grilla);
            propiedades_grilla(Grilla2);
            llenar_articulos();
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_artxprov(Grilla["idarticulo", Grilla.SelectedCells[0].RowIndex].Value.ToString().Trim());

        }
    }
}
