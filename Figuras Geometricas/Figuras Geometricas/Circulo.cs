using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Circulo
    {
        private static double radio;
        
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        } 

        public double Calculo_Area()
        {
            return Math.PI * radio * radio;
        }
    }
}
