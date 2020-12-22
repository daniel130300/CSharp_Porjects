using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienes_Inmuebles
{
    public class Informacion_general
    {
        protected static string ubicacion;
        protected static string dimensiones;
        protected static double precio;

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public string Dimensiones
        {
            get { return dimensiones; }
            set { dimensiones = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
