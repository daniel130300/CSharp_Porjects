using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Pizza
    {

        //Atributos

        private double subtotal;
        private double isv;
        private double total;

        //Constructor

        public Pizza()
        {
            subtotal = 0;
            isv = 0;
            total = 0;
        }

        //Propiedades

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        //Metodos

        public double Calculo_Isv()
        {
            return isv = subtotal * 0.15;
        }

        public double Calculo_Total()
        {
            return total = subtotal + isv;
        }
    }
}
