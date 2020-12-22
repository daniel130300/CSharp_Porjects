using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienes_Inmuebles
{
    public class Edificio:Informacion_general
    {

        private static int no_pisos, no_habitaciones, no_baños, no_estacionamientos;
        private static string extras;

        public Edificio (int pisos, int habitaciones, int baños, int estacionamiento, string ex)
        {
            no_pisos = pisos;
            no_habitaciones = habitaciones;
            no_baños = baños;
            no_estacionamientos = estacionamiento;
            extras = ex;
        }
    }
}
