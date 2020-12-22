using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsdrasPerdomo
{
    class Tractor:Vehiculo
    {
        private static int precio_dia;
        private static int cantidad_dias;

        //Propiedades

        public int Precio_dia
        {
            get
            { return precio_dia; }

            set
            { precio_dia = value; }
        }

        public int Cantidad_dias
        {
            get
            { return cantidad_dias;}

            set
            { cantidad_dias = value;}
        }

    }
}
