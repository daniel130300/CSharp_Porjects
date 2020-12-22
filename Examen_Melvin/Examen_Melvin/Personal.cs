using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Melvin
{
    public class Personal:Prestamos
    {
        private static string nombre_aval_1;
        private static string nombre_aval_2;
        private static double sueldo_cliente;

        public Personal (string nombre1, string nombre2, double sueldo)
        {
            nombre_aval_1 = nombre1;
            nombre_aval_2 = nombre2;
            sueldo_cliente = sueldo;
        }

        public override string InformacionPrestamo()
        {
            return "El número de prestamo solicitado es: " + numero_prestamo +
                    "\n el tipo de prestamo es: " + tipo_prestamo +
                    "\n el nombre del cliente es: " + nombre_cliente +
                    "\n el nombre del 1er aval es: " + nombre_aval_1 +
                    "\n el nombre del 2do aval es: " + nombre_aval_2 +
                    "\n el sueldo del clientes es: " + sueldo_cliente;
        }
    }
}
