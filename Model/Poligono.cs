using FiguraGeometrica2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica2.Model
{
    internal class Poligono : IFigura
    {
        decimal lado;
        public int cantidad;

        public Poligono(decimal lado, int cantidad)
        {
            this.lado = lado;
            this.cantidad = cantidad;
        }

        public decimal CalcularArea()
        {
            decimal area = (cantidad * lado * lado) / 
                (4 * (decimal)Math.Tan((double)(Math.PI / cantidad)));
            return area;
        }

        public decimal CalcularPerimetro()
        {
            decimal p = lado * cantidad;
            return p;
        }
    }
}
