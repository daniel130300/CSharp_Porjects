using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public class Vehiculos
    {

        public string color;
        public string marca;
        public string modelo;

        public string UnVehiculo(string col, string mar, string mode)
        {
            string a;
            a = col + " " + mar + " " + mode;
            return a;
        }

        public void UnVehiculo()
        {
            color = "Dorado";
            marca = "Nissan";
            modelo = "X-trail";

            MessageBox.Show((color + marca + modelo), "Polimorfismo Parametrizado");
        }

    }
}
