using FiguraGeometrica2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguraGeometrica2
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblRadio_Click(object sender, EventArgs e)
        {
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            lblRadio.Visible = true; txtRadio.Visible = true;

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            lblLadoC.Visible = true; txtLadoC.Visible = true;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            lblAltura.Visible = true; txtResAltura.Visible = true;
        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {
            txtResArea.Text = string.Empty;
            txtResPerimetro.Text = string.Empty;

            if (decimal.TryParse(txtLadoC.Text, out decimal lado))
            {
                Cuadrado cuadrado = new Cuadrado(lado);

                decimal area = cuadrado.CalcularArea();
                decimal perimetro = cuadrado.CalcularPerimetro();

                txtResArea.AppendText($"{area}");
                txtResPerimetro.AppendText($"{perimetro}");
            }
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {
            txtResArea.Text = string.Empty;
            txtResPerimetro.Text = string.Empty;

            if (double.TryParse(txtRadio.Text, out double radio))
            {
                Circulo circulo = new Circulo(radio);

                decimal area = circulo.CalcularArea();
                decimal perimetro = circulo.CalcularPerimetro();

                txtResArea.AppendText($"{area}");
                txtResPerimetro.AppendText($"{perimetro}");
            }

        }

        private void lblLadoC_Click(object sender, EventArgs e)
        {
        }

        private void txtResAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
