using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales_BDD
{
    public class Insecto:Animales
    {
        protected static bool vuela; 

        public Insecto (bool vue)
        {
            vuela = vue;
        }

        //Metodo

        public override string QueClasedeAnimalEres()
        {

            if (vuela == true)
            {
                return "Soy un insecto llamado" + nombre +
                       "\n de especie " + especie +
                       "\n peso en kg " + peso +
                        "\n y si vuelo " + 
                        "\n estoy en la jaula " + jaula;
            }
            else
            {
                return "Soy un insecto llamado" + nombre +
                       "\n de especie " + especie +
                       "\n peso en kg " + peso +
                        "\n y no vuelo " +
                        "\n estoy en la jaula " + jaula;
            }
        }
    }
}
