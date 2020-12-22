using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    public class Calculos
    {

        //Atributos
        
        private double subtotal;
        private double cal_desc;
        private double descuento;
        private double isv;
        private double total;

        //Constructor

        public Calculos()
        {
            subtotal = 0;
            isv = 0;
            total = 0;
            cal_desc = 0;
            descuento = 0;
        }

        //Propiedades 

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        //Metodos

        public double Calculo_descuento()
        {
            return cal_desc = subtotal * descuento;
        }

        public double Calculo_ISV()
        {
            return isv = (subtotal- cal_desc) * 0.15; 
        }

        public double Calculo_Total()
        {
            return total = (subtotal- cal_desc) + isv;
        }
    }
}
