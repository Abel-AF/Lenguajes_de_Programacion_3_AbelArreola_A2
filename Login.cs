using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string passwordOk = "12345";
            if (textPassword.Text == passwordOk)
            {
                MessageBox.Show("Ingreso exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu ventanaMenu = new Menu();
                ventanaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Clear();
            }
        }
    }
}