using FiguraGeometrica2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica2.Model
{
    internal class Triangulo : IFigura
    {
        decimal lado1;
        decimal lado2;
        decimal lado3;

        public Triangulo(decimal lado1, decimal lado2, decimal lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public decimal CalcularArea()
        {
            if(lado1 == lado2 && lado1 == lado3) 
            {
                decimal h = (decimal)(Math.Sqrt(3) / 2) * lado1;
                decimal a = (lado2 * h) / 2; 
                return a;
            }
            else
            {
                decimal s = (lado1 + lado2 + lado3) / 2; // Semiperímetro
                decimal area = (decimal)Math.Sqrt((double)(s * (s - lado1) * (s - lado2) * (s - lado3)));
                return area;
            }
        }

        public decimal CalcularPerimetro()
        {
            var p = lado1 + lado2 + lado3;
            return p;
        }

        public decimal CalcularAltura() 
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                decimal h = (decimal)(Math.Sqrt(3) / 2) * lado1;
                return h;
            }
            else 
            {
                decimal s = (lado1 + lado2 + lado3) / 2; // Semiperímetro
                decimal area = 
                    (decimal)Math.Sqrt((double)(s * (s - lado1) * (s - lado2) * (s - lado3)));

                decimal h1 = 2 * area / lado1;
                decimal h2 = (2 * area) / lado2; 
                decimal h3 = (2 * area) / lado3; 
                decimal AlturaFinal = h1 + h2 + h3;
                return AlturaFinal;
            }
        }
    }
}
