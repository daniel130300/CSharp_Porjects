using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcos
{
    public class Calculos
    {

        //Atributos

        private int precio;
        private int eslora;
        private int dias;
        private double subtotal;
        private double isv;
        private double total;

        //Constructor

        public Calculos()
        {
            precio = 0;
            eslora = 0;
            dias = 0;
            subtotal = 0;
            isv = 0;
            total = 0;
        }

        //Propiedades

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Eslora
        {
            get { return eslora; }
            set { eslora = value; }
        }

        public int Dias
        {
            get { return dias; }
            set { dias = value; }
        }

        //Metodos

        public double Calculo_Subtotal()
        {
            return subtotal = (precio * dias) * (eslora * 10) * 2;
        }

        public double Calculo_ISV()
        {
            return isv = subtotal * 0.15;
        }

        public double Calculo_Total()
        {
            return total = subtotal + isv;
        }
    }
}
