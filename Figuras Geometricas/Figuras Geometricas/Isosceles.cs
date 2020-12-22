using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Figuras_Geometricas
{
    public class Isosceles:Triangulo
    {
        private static int lado, bas;

        public Isosceles(int la, int ba)
        {
            lado = la;
            bas = ba;
        }

        public override string Area()
        {
            return "Tipo de triangulo: " + nombre +
             "\nArea: " + (bas * Math.Sqrt(Math.Pow(2, lado) - (Math.Pow(2, bas)/4)));
        }
    }
}
