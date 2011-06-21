using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public void validacion_log(int a)
        {
            if (textBox1.Text.Length > a)
            {
                MessageBox.Show("Por Favor ingrese un nombre de usuario valido");
                textBox1.Focus();
            }
            else if (textBox2.Text.Length > a)
            {
                MessageBox.Show("Por Favor ingrese una contraseña valida");
                textBox2.Focus();
            }
            else this.Close();
        }
        
        public Login()
        {
            InitializeComponent();
        }

        private void logear_Click(object sender, EventArgs e)
        {
            validacion_log(9);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                validacion_log(9);
            }
        }
    

    }
}
