using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homonimia
{
    public class Suma
    {
        private int sum;

        //Homo: Igual, Nimia: Nombre, osea el mismo nombre
        //Tambien se le conoce omo sobrecarga.

        public int sumas (int a, int b)
        {
            sum = a + b;
            return sum;
        }

        public int sumas(int a, int b, int c)
        {
            sum = a + b + c;
            return sum;
        }

        public int sumas(int a, int b, int c, int d)
        {
            sum = a + b+ c + d;
            return sum;
        }
    }
}
