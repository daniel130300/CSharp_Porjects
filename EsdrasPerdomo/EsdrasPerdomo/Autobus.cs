using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsdrasPerdomo
{
    class Autobus : Vehiculo
    {

        private static int kilometos_inciales;
        private static int kilometros_finales;

        //Propiedades

        public int Kilometos_inciales
        {
            get
            { return kilometos_inciales; }

            set
            { kilometos_inciales = value; }
        }

        public int Kilometros_finales
        {
            get
            { return kilometros_finales; }

            set
            { kilometros_finales = value; }
        }

    }
}
