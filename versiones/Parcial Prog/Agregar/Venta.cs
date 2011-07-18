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
    public partial class Venta : Form
    {
        private Principal principal;
        public Venta(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        string nombreart = null;
        float precio = 0;
        float total = 0;
        bool stock = false;

        private void habilitar_boton ()
        {
            boton_agregar.Enabled = false;
            if(tb_idart.Text.Length != 0 && tb_cantidad.Text.Length != 0)
            {
                boton_agregar.Enabled = true;
            }
        }

        private bool verif_stock()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            //string consulta = "select Articulos.nombre, Articulos.marca, Articulos.stock from Articulos INNER JOIN ArticulosxProv ON Articulos.idarticulo = ArticulosxProv.idarticulo WHERE Articulos.stock < 5";
            string consulta = "select Articulos.nombre, Articulos.marca, Articulos.stock from Articulos WHERE Articulos.stock < 5";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet dataset = new DataSet();
            conexion.Open();
            adaptador.Fill(dataset, "Sinstock");
            DataGridView grilla_ver = new DataGridView();
            grilla_ver.DataSource = dataset.Tables["Sinstock"];
            if (grilla_ver.Rows.Count - 1 != 0)
                return true;
            else return false;
        }

        private bool buscar_idartfac()
        {
            if (Funciones.validacion_num(tb_idart.Text))
            {
                string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
                SqlConnection conexion = new SqlConnection(rutaSql);
                conexion.Open();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = conexion;
                comandosql.Parameters.AddWithValue("@codigo", tb_idart.Text);
                comandosql.CommandText = "Buscarxcod";
                comandosql.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
                DataSet dataset = new DataSet();
                dataset.Clear();
                adaptador.Fill(dataset, "Articulosbuscados");
                DataGridView grilla3 = new DataGridView();
                grilla3.DataSource = dataset.Tables["Articulosbuscados"];
                this.Controls.Add(grilla3);
                if (grilla3.Rows.Count - 1 != 0)
                {
                    if (int.Parse(grilla3["stock", 0].Value.ToString()) >= int.Parse(tb_cantidad.Text))
                    {
                        nombreart = grilla3.Rows[0].Cells[1].Value.ToString().Trim() + " " + grilla3.Rows[0].Cells[2].Value.ToString().Trim();
                        precio = float.Parse(grilla3.Rows[0].Cells[3].Value.ToString().Trim());
                        adaptador.Dispose();
                        this.Controls.Remove(grilla3);
                        stock = false;
                        return true;
                    }
                    else
                    {
                        adaptador.Dispose();
                        this.Controls.Remove(grilla3);
                        tb_cantidad.Text = null;
                        tb_cantidad.Focus();
                        MessageBox.Show("Stock insuficiente");
                        stock = true;
                        return false;
                    }
                }
                adaptador.Dispose();
                this.Controls.Remove(grilla3);
                stock = false;
                return false;
            }
            stock = false;
            return false;
        }

        private string ob_numfactura()
        {
            int a;
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.CommandText = "Buscarnfactura";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "nfactura");
            DataGridView grilla2 = new DataGridView();
            grilla2.DataSource = dataset.Tables["nfactura"];
            this.Controls.Add(grilla2);
            grilla2.Hide();
            adaptador.Dispose();
            if(grilla2.Rows[0].Cells[0].Value != null )
            a = Int32.Parse(grilla2.Rows[0].Cells[0].Value.ToString()) + 1;
            else a = 0;
            this.Controls.Remove(grilla2);
            return a.ToString();
        }
        
        private void crear_factura()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@total", float.Parse(lb_total.Text));
            comandosql.Parameters.AddWithValue("@fecha", fecha.Text);
            comandosql.CommandText = "Ing_Factura";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Nuevafactura");
            adaptador.Dispose();
        }

        private void Realizar_Update(string a,int b)
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", a);
            comandosql.Parameters.AddWithValue("@cantidad", b);
            comandosql.CommandText = "Modif_Stock";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Stockmodif");
        }

        public void Buscar_codigo()
        {
            string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaSql);
            conexion.Open();       
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conexion;
            comandosql.Parameters.AddWithValue("@codigo", int.Parse(tb_idart.Text));
            comandosql.CommandText = "Buscarxcod";
            comandosql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
            DataSet dataset = new DataSet();
            dataset.Clear();
            adaptador.Fill(dataset, "Artbuscado");
            DataGridView grilla = new DataGridView();
            grilla.DataSource = dataset.Tables["Artbuscado"];
            this.Controls.Add(grilla);
            if (grilla.Rows.Count - 1 != 0)
            {
                lb_nombreart.Text = grilla["nombre", 0].Value.ToString().Trim() + " " + grilla["marca", 0].Value.ToString().Trim() + " $" + float.Parse(grilla["precio", 0].Value.ToString().Trim());  
            }
            grilla.Hide();
            this.Controls.Remove(grilla);
            adaptador.Dispose();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            Grilla.Columns.Add("id", "Idart");
            Grilla.Columns.Add("articulo", "Articulo");
            Grilla.Columns.Add("cantidad", "Cantidad");
            Grilla.Columns.Add("importe", "Importe");
            tb_nfactura.Text = ob_numfactura();
            lb_errorid.Text = null;
            lb_errorcant.Text = null;
            lb_nombreart.Text = null;
            botonborrar.Enabled = false;
            habilitar_boton();
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            if (buscar_idartfac())
            {
                lb_errorid.Text = null;
                lb_errorcant.Text = null;
                if(Funciones.validacion_num(tb_cantidad.Text))
                {
                    total += precio * int.Parse(tb_cantidad.Text);
                    Grilla.Rows.Add(tb_idart.Text, nombreart, tb_cantidad.Text, precio * float.Parse(tb_cantidad.Text));
                    tb_idart.Text = null;
                    tb_cantidad.Text = null;
                    lb_total.Text = total.ToString();
                    tb_idart.Focus();
                    botonborrar.Enabled = true;
                }
                else lb_errorcant.Text = "No es un valor numerico";
            }
            else if (stock)
            {
                lb_errorid.Text = null;
            }
            else lb_errorid.Text = "El ID no es correcto";
        }

        private void Venta_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.editarToolStripMenuItem.Enabled = true;
            principal.realizarVentaToolStripMenuItem.Enabled = true;
            if (verif_stock())
            {
                this.Hide();
                PuntoPedido punto_pedido = new PuntoPedido();
                punto_pedido.ShowDialog();
            }

        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            if (Grilla.Rows.Count != 0)
            {
                crear_factura();
                int a = Grilla.Rows.Count;

                for (int i = 0; i < a; i++)
                {
                    Realizar_Update(Grilla["id", i].Value.ToString().Trim(),int.Parse(Grilla["cantidad", i].Value.ToString().Trim()));
                    string rutaSql = "Data Source=localhost;Initial Catalog=Almacen;Integrated Security=True";
                    SqlConnection conexion = new SqlConnection(rutaSql);
                    conexion.Open();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = conexion;
                    comandosql.Parameters.AddWithValue("@idfactura", tb_nfactura.Text);
                    comandosql.Parameters.AddWithValue("@idarticulo", Grilla["id", i].Value.ToString().Trim());
                    comandosql.Parameters.AddWithValue("@cantidad", Grilla["cantidad",i].Value.ToString().Trim());
                    comandosql.CommandText = "Ing_DetalleFactura";
                    comandosql.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comandosql);
                    DataSet dataset = new DataSet();
                    dataset.Clear();
                    adaptador.Fill(dataset, "Detallenuevo");
                    adaptador.Dispose();
                    
                }
                MessageBox.Show("Su venta se realizo correctamente");
                Grilla.Rows.Clear();
                lb_total.Text = "0";
                tb_nfactura.Text = ob_numfactura();
            }
            else MessageBox.Show("Ingrese articulos");

        }

        private void botonborrar_Click(object sender, EventArgs e)
        {
            if (Grilla.Rows.Count != 0)
            {
                //int a = Grilla.Rows.Count - 1;
                int a = Grilla.SelectedCells[0].RowIndex;
                float b;
                b = float.Parse(Grilla["importe",a].Value.ToString());
                total -= b;
                lb_total.Text = total.ToString();
                Grilla.Rows.Remove(Grilla.Rows[a]);
                if (Grilla.Rows.Count == 0)
                    botonborrar.Enabled = false;
            }
            else 
                botonborrar.Enabled = false;
        }

        private void tb_idart_TextChanged(object sender, EventArgs e)
        {
            if (tb_idart.Text.Length != 0)
            {
                try { Buscar_codigo(); }
                catch { }
                habilitar_boton();
            }
            else lb_nombreart.Text = null;
        }

        private void tb_cantidad_TextChanged(object sender, EventArgs e)
        {
            habilitar_boton();
        }        
    }
}