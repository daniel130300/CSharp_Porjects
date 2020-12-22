using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Bienes_Inmuebles
{
    public class Terreno
    {
        protected static string ubicacion, dimensiones;
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
