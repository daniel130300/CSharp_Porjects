using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Calculo
    {
        private static double impuesto;

        public double Impuesto
        {
            get { return impuesto; }
        }
         
        public double Calculo_factura(double subtot, double desc, double isv)
        {
            impuesto = ((subtot - (subtot*desc))*isv);
            return (subtot - (subtot * desc)) + impuesto;  
        }

        public double Calculo_factura(double subtot, double desc1, double desc2, double isv)
        {
            double descuentoTotal = desc1 + desc2;

            impuesto = ((subtot - (subtot * descuentoTotal)) * isv);
            return (subtot - (subtot * descuentoTotal)) + impuesto;
        }
    }
}
