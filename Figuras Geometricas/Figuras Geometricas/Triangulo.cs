using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Triangulo
    {

        protected static string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public virtual string Area()
        {
            return "Tipo de triangulo: " + nombre;
        } 
          
    }
}
