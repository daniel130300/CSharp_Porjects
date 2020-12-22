using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homonimia_Factura
{
    public class Calculo_Factura
    {
      

        public double Total_Factura(double subtot, double desc, double isv)
        {
            return subtot - ((subtot * desc) + ((subtot - (subtot * desc)) * isv));
        }

        public double Total_Factura(double subtot, double isv, double desc1, double desc2)
        {
            double desctotal = desc1 + desc2;

            return subtot - ((subtot * desctotal) + ((subtot - (subtot * desctotal)) * isv));
        }




    }
}
