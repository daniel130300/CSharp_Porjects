using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienes_Inmuebles
{
    public class Casa:Informacion_general
    {
        private static int no_habitaciones, no_baños, no_estacionamientos;
        private static string extras;

        public Casa (int habitaciones, int baños, int estacionamiento, string ex)
        {
            no_habitaciones = habitaciones;
            no_baños = baños;
            no_estacionamientos = estacionamiento;
            extras = ex;
        }
    }
}
