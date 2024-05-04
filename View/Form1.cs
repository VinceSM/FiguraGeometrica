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
        private void LimpiarInputs()
        {
            txtResArea.Text = string.Empty;
            txtResPerimetro.Text = string.Empty;
            txtResAltura.Text = string.Empty;
            txtLadoC.Text = string.Empty;
            txtLado1.Text = string.Empty;
            txtLado2.Text = string.Empty;
            txtLado3.Text = string.Empty;
            txtRadio.Text = string.Empty;
            txtLadoP.Text = string.Empty;
            txtCantidadP.Text = string.Empty;  
        }

        private void DeshabilitarPoligono()
        {
            lblLadoP.Visible = false;
            txtLadoP.Visible = false;

            lblCantidadP.Visible = false;
            txtCantidadP.Visible = false;
        }

        private void DeshabilitarTriangulo()
        {
            lblAltura.Visible = false;
            txtResAltura.Visible = false;
            lblLado1.Visible = false; txtLado1.Visible = false;
            lblLado2.Visible = false; txtLado2.Visible = false;
            lblLado3.Visible = false; txtLado3.Visible = false;
        }

        private void DeshabilitarCuadrado()
        {
            lblLadoC.Visible = false; txtLadoC.Visible = false;
        }

        private void DeshabilitarCirculo()
        {
            lblRadio.Visible = false;
            txtRadio.Visible = false;
        }

        private void HabilitarTriangulo()
        {

            lblLado1.Enabled = true; txtLado1.Enabled = true;
            lblLado2.Enabled = true; txtLado2.Enabled = true;
            lblLado3.Enabled = true; txtLado3.Enabled = true;

            lblLado1.Visible = true; txtLado1.Visible = true;
            lblLado2.Visible = true; txtLado2.Visible = true;
            lblLado3.Visible = true; txtLado3.Visible = true;

            lblAltura.Enabled = true; txtResAltura.Enabled = true;
            lblAltura.Visible = true; txtResAltura.Visible = true;
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

                txtResArea.AppendText($"{area:N2}");
                txtResPerimetro.AppendText($"{perimetro:N2}");
                txtResAltura.AppendText($"{altura:N2}");
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            txtRadio.Visible = true;
            lblRadio.Visible = true;
            txtRadio.Enabled = true;
            lblRadio.Enabled = true;
            LimpiarInputs();
            DeshabilitarTriangulo();
            DeshabilitarCuadrado();
            DeshabilitarPoligono();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            txtLadoC.Visible = true;
            lblLadoC.Visible = true;
            txtLadoC.Enabled = true;
            lblLadoC.Enabled = true;
            LimpiarInputs();
            DeshabilitarCirculo();
            DeshabilitarTriangulo();
            DeshabilitarPoligono();
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            lblCantidadP.Visible = true; lblCantidadP.Enabled = true;
            txtCantidadP.Visible = true; txtCantidadP.Enabled = true;

            lblLadoP.Visible = true; lblLadoP.Enabled = true;
            txtLadoP.Visible = true; txtLadoP.Enabled = true;

            LimpiarInputs();
            DeshabilitarCirculo();
            DeshabilitarTriangulo();
            DeshabilitarCuadrado();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            LimpiarInputs();
            HabilitarTriangulo();
            DeshabilitarCirculo();
            DeshabilitarCuadrado();
            DeshabilitarPoligono();

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

                txtResArea.AppendText($"{area:N2}");
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

                txtResArea.AppendText($"{area:N2}");
                txtResPerimetro.AppendText($"{perimetro:N2}");
            }

        }

        private void LogicaPoligono()
        {
            txtResArea.Text = string.Empty;
            txtResPerimetro.Text = string.Empty;

            var l = decimal.TryParse(txtLadoP.Text, out decimal lado);
            var c = int.TryParse(txtCantidadP.Text, out int cantidad);

            if (l && c)
            {
                Poligono poligono = new Poligono(lado, cantidad);

                decimal area = poligono.CalcularArea();
                decimal perimetro = poligono.CalcularPerimetro();

                txtResArea.AppendText($"{area:N2}");
                txtResPerimetro.AppendText($"{perimetro}");
            }
        }

        private void txtLadoP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidadP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { LogicaPoligono(); }
        }

        private void txtLadoP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { LogicaPoligono(); }
        }

        private void txtCantidadP_TextChanged(object sender, EventArgs e)
        {

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
