using FiguraGeometrica2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica2.Model
{
    internal class Cuadrado : IFigura
    {
        decimal lado;
        public decimal CalcularArea()
        {
            return lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
