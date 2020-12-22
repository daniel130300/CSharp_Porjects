using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Equilatero: Triangulo
    {

        private static int lado;

        public Equilatero (int lad)
        {
            lado = lad;
        }

        public override string Area()
        {
             return "Tipo de triangulo: " + nombre +
             "\nArea: " + ((Math.Sqrt(3)/4) * lado * lado);
        }
    }
}
