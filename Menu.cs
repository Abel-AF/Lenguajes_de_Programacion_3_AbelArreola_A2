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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saludo ventanaSaludo = new Saludo();
            ventanaSaludo.ShowDialog();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionPersonal ventanaInformacionPersonal = new InformacionPersonal();
            ventanaInformacionPersonal.ShowDialog();
        }

        private void operacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesBasicas ventanaOperaciones = new OperacionesBasicas();
            ventanaOperaciones.Show();
        }
    }
}
