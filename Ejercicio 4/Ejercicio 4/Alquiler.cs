using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Alquiler
    {
        //Atributos

        private double precio;
        private int dias;
        private int eslora;
        private double alquiler;

        //Constructor

        public Alquiler()
        {
            precio = 0;
            dias = 0;
            eslora = 0;
            alquiler = 0;
        }

        //Propiedades

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public int Dias
        {
            get { return dias; }
            set {dias = value; }
        }

        public int Eslora
        {
            get { return eslora; }
            set { eslora = value; }
        }

        //Metodos

        public double Calculo_alquiler()
        {
            return alquiler = precio * dias * (eslora * 10) * 2;
        }
    }
}
