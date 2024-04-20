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


        private void btnCirculo_Click(object sender, EventArgs e)
        {
            txtRadio.Enabled = true;
            //limpiar txt
            txtResArea.Text = string.Empty; txtResPerimetro.Text = string.Empty;
            txtLadoC.Text = string.Empty;
            txtLado1.Text = string.Empty;
            txtLado2.Text = string.Empty;
            txtLado3.Text = string.Empty;

            //lbl y txt de Circulo
            lblRadio.Visible = true; txtRadio.Visible = true;

            //lbl y txt de otras figuras
            txtLadoC.Enabled = false;
            txtLado1.Enabled = false;
            txtLado2.Enabled = false; txtLado3.Enabled = false;

            //lbl y txt de Altura
            lblAltura.Visible = false; txtResAltura.Visible = false;

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            txtLadoC.Enabled = true;
            //limpiar txt
            txtResArea.Text = string.Empty;
            txtResPerimetro.Text = string.Empty;
            txtRadio.Text = string.Empty;
            txtLado1.Text = string.Empty;
            txtLado2.Text = string.Empty;
            txtLado3.Text = string.Empty;

            //lbl y txt de Cuadrado
            lblLadoC.Visible = true; txtLadoC.Visible = true; txtLadoC.Enabled = true;

            //lbl y txt de Altura
            lblAltura.Visible = false; txtResAltura.Visible = false;

            //txt de otras figuras
            txtRadio.Enabled = false; txtLado1.Enabled = false;
            txtLado2.Enabled = false; txtLado3.Enabled = false;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            //limpiar txt
            txtResArea.Text = string.Empty;
            txtResPerimetro.Text = string.Empty;
            txtResAltura.Text = string.Empty;
            txtLadoC.Text = string.Empty; 
            txtRadio.Text = string.Empty;

            //lbl y txt de Triangulo
            lblLado1.Visible = true; txtLado1.Visible = true; 
            txtLado1.Enabled = true; txtLado2.Enabled = true; txtLado3.Enabled = true;
            lblLado2.Visible = true; txtLado2.Visible = true;
            lblLado3.Visible = true; txtLado3.Visible = true;

            //txt de otras figuras
            txtRadio.Enabled = false; txtLadoC.Enabled = false;

            //lbl y txt de Altura
            lblAltura.Visible = true; txtResAltura.Visible = true;

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

        private void LogicaLadosTriangulo()
        {
            txtResArea.Text = string.Empty;
            txtResPerimetro.Text = string.Empty;
            txtResAltura.Text = string.Empty;

            var a = decimal.TryParse(txtLado1.Text, out decimal lado1);
            var b = decimal.TryParse(txtLado2.Text, out decimal lado2);
            var c = decimal.TryParse(txtLado3.Text, out decimal lado3);

            if (a && b && c)
            {
                Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

                decimal area = triangulo.CalcularArea();
                decimal perimetro = triangulo.CalcularPerimetro();
                decimal altura = triangulo.CalcularAltura();

                txtResArea.AppendText($"{area}");
                txtResPerimetro.AppendText($"{perimetro}");
                txtResAltura.AppendText($"{altura}");
            }
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLado1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { LogicaLadosTriangulo(); }
        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLado2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { LogicaLadosTriangulo(); }
        }

        private void txtLado3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLado3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { LogicaLadosTriangulo(); }

        }

        private void lblRadio_Click(object sender, EventArgs e)
        {
        }

        private void lblLado1_Click(object sender, EventArgs e)
        {

        }

        private void lblLado2_Click(object sender, EventArgs e)
        {

        }

        private void lblLado3_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblLadoC_Click(object sender, EventArgs e)
        {
        }

        private void txtResAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
