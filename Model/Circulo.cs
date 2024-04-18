using FiguraGeometrica2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica2.Model
{
    internal class Circulo : IFigura
    {
        double radio;

        public decimal CalcularArea()
        {
            var a = (decimal)(Math.PI * Math.Pow(radio, 2));
            return a;
        }

        public decimal CalcularPerimetro()
        {
            var p = (decimal)(2 * Math.PI * radio);
            return p;
        }
    }
}
