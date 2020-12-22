using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Melvin
{
    public class Hipotecario:Prestamos
    {
        private static int numero_catastral;
        private static string ubicacion;
        private static double valor_bien;

        public Hipotecario (int numero, string ubi, double valor)
        {
            numero_catastral = numero;
            ubicacion = ubi;
            valor_bien = valor;
        }

        public override string InformacionPrestamo()
        {
            return "El número de prestamo solicitado es: " + numero_prestamo +
                    "\n el tipo de prestamo es: " + tipo_prestamo +
                    "\n el nombre del cliente es: " + nombre_cliente +
                    "\n el número catastral es: " + numero_catastral +
                    "\n la ubicación de la vivienda es: " + ubicacion +
                    "\n el valor del bien es de: " + valor_bien;
        }

    }
}
