using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    public class Cajero
    {
        //Atributos

        private int resultado;
        public int saldo_actual;
        private int cantidad;

        //Constructor

        public Cajero()
        {
            saldo_actual = 0;
            cantidad = 0;
        }

        //Propiedades

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //Métodos

        public double Calculo_saldo()
        {
            return resultado = saldo_actual - cantidad;
        }
    }
}
