using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Escaleno : Triangulo
    {
        private static int bas, alt;

        public Escaleno(int ba, int al)
        {
            bas = ba;
            alt = al;
        }

        public override string Area()
        {
            return "Tipo de triangulo: " + nombre +
              "\nArea: " + ((bas * alt)/2);
        }
    }
}
