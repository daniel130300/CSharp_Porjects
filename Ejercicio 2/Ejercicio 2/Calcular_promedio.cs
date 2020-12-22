using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Calcular_promedio
    {
        //Atributos

        private int nota1;
        private int nota2;
        private int  nota3;
        private double promedio;

        //Constructor

        public Calcular_promedio()
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            promedio = 0;
        }

        //Propiedades

        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public int Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        //Metodos

        public double Calculo_promedio()
        {
            return promedio = (0.25 * nota1) + (0.35 * nota2) + (0.40 * nota3);
        }
    }
}
