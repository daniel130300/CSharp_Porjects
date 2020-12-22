using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class Calculo_costo
    {

        //Atributos

        public int peso;
        public double costo;

        //Constructor

        public Calculo_costo()
        {
            peso = 0;
            costo = 0;
        }

        //Metodos

        public double Calculo_peso()
        {
            if (peso < 5)
                return costo = (peso * 0.5);
            else
                return costo = 2.50 +(peso - 5) * 0.25;
        }
    }
}
