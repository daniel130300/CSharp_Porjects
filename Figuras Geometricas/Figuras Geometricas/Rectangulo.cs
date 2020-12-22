using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Rectangulo
    {

        private static int altura;
        private static int bas;

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public int Bas
        {
            get { return bas; }
            set { bas = value; }
        }

        public double Calculo_Area()
        {
            return altura * bas;
        }

    }
}
