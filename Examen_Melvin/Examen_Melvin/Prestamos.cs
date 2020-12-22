using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Melvin
{
    public class Prestamos
    {
        protected static int numero_prestamo;
        protected static string nombre_cliente;
        protected static string tipo_prestamo;
        
        
        public int Numero_prestamo
        {
            get { return numero_prestamo; }
            set { numero_prestamo = value; }
        } 

        public string Nombre_cliente
        {
            get { return nombre_cliente; }
            set { nombre_cliente = value; }
        }

        public string Tipo_prestamo
        {
            get { return tipo_prestamo; }
            set { tipo_prestamo = value; }
        }

        public virtual string InformacionPrestamo()
        {
            return "El número de prestamo solicitado es: " + numero_prestamo +
                    "\n el tipo de prestamo es: " + tipo_prestamo +
                    "\n el nombre del cliente es: " + nombre_cliente;
        }
    }
}
