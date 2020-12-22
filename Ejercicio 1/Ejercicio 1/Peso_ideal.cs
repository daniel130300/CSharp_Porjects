using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Peso_ideal
    {

        //Atributos

        private double estatura;
        private double peso;
        private double resp;

        //Constructor

        public Peso_ideal()
        {
            estatura = 0;
            peso = 0;
            resp = 0;
        }

        //Propiedades

        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        //Metodos

        public double Calculo_peso()
        {
            return resp = (estatura - 1) * 100 * 2.2;
        }

    }
}
