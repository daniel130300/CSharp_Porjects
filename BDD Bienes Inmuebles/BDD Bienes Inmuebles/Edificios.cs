using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Bienes_Inmuebles
{
    public class Edificios:Terreno
    {
        private static string extras;
        private static int no_pisos, no_habitaciones, no_baños, no_estacionamientos;

        public Edificios (string ex, int pisos, int habitaciones, int baños, int estacionamientos)
        {
            no_pisos = pisos;
            no_habitaciones = habitaciones;
            no_baños = baños;
            no_estacionamientos = estacionamientos;
            extras = ex;
        }
    }
}
