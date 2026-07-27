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
    public partial class OperacionesBasicas : Form
    {
        public OperacionesBasicas()
        {
            InitializeComponent();
        }

        private bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text) ||
                string.IsNullOrWhiteSpace(txtNum3.Text) || string.IsNullOrWhiteSpace(txtNum4.Text) ||
                string.IsNullOrWhiteSpace(txtNum5.Text) || string.IsNullOrWhiteSpace(txtNum6.Text))
            {
                MessageBox.Show("Favor de llenar todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                double n1 = double.Parse(txtNum1.Text);
                double n2 = double.Parse(txtNum2.Text);
                double n3 = double.Parse(txtNum3.Text);
                double n4 = double.Parse(txtNum4.Text);
                double n5 = double.Parse(txtNum5.Text);
                double n6 = double.Parse(txtNum6.Text);
                double resultado = n1 + n2 + n3 + n4 + n5 + n6;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                double n1 = double.Parse(txtNum1.Text);
                double n2 = double.Parse(txtNum2.Text);
                double n3 = double.Parse(txtNum3.Text);
                double n4 = double.Parse(txtNum4.Text);
                double n5 = double.Parse(txtNum5.Text);
                double n6 = double.Parse(txtNum6.Text);
                double resultado = n1 - n2 - n3 - n4 - n5 - n6;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                double n1 = double.Parse(txtNum1.Text);
                double n2 = double.Parse(txtNum2.Text);
                double n3 = double.Parse(txtNum3.Text);
                double n4 = double.Parse(txtNum4.Text);
                double n5 = double.Parse(txtNum5.Text);
                double n6 = double.Parse(txtNum6.Text);
                double resultado = n1 * n2 * n3 * n4 * n5 * n6;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                double n1 = double.Parse(txtNum1.Text);
                double n2 = double.Parse(txtNum2.Text);
                double n3 = double.Parse(txtNum3.Text);
                double n4 = double.Parse(txtNum4.Text);
                double n5 = double.Parse(txtNum5.Text);
                double n6 = double.Parse(txtNum6.Text);
                if (n2== 0 || n3 == 0 || n4 == 0 || n5 == 0 || n6 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "Error de división", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double resultado = n1 / n2 / n3 / n4 / n5 / n6;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            txtNum4.Text = "";
            txtNum5.Text = "";
            txtNum6.Text = "";
            txtResultado.Text = "";
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}