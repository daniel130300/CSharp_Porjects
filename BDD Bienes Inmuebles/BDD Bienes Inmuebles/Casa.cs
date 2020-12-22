using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Bienes_Inmuebles
{
    public class Casa:Terreno
    {
        private static string extras;
        private static int no_habitaciones, no_baños, no_estacionamientos;

        public Casa (string ex, int habitaciones, int baños, int estacionamientos)
        {
            no_habitaciones = habitaciones;
            no_baños = baños;
            no_estacionamientos = estacionamientos;
            extras = ex;
        }
    }
}
