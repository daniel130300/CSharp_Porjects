using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales_BDD
{
    public class Ave:Animales
    {
        protected static string color_plumaje;
        protected static double altura_maxima_vuelo;

        public Ave (string col, double alt)
        {
            color_plumaje = col;
            altura_maxima_vuelo = alt;
        }

        //Metodo

        public override string QueClasedeAnimalEres()
        {
            return "Soy un ave llamado" + nombre +
                    "\n de especie " + especie +
                    "\n de color " + color_plumaje +
                    "\n tengo una altura maxima de vuelo de " + altura_maxima_vuelo +
                    "\n peso en kg " + peso +
                    "\n estoy en la jaula " + jaula;
        }
    }
}
