using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    class Cuenta
    {
        private static string Titular;
        private static double Cantidad;
        private static double Saldo;

        public Cuenta(string titular, double saldo, double cantidad)
        {
            Saldo = saldo;
            Titular = titular;
            Cantidad = cantidad;
        }

        public Cuenta(string titular)
        {
            Titular = titular;
        }

        public double Ingresar()
        {
            if (Cantidad < 0)
                return 0;
            else
                return (Saldo + Cantidad);    
        }

        public double Retirar()
        {
            if (Cantidad > Saldo)
                return 0;
            else
                return (Saldo - Cantidad);
        }
        
    }
}
