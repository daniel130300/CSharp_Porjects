using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales_BDD
{
    public class Animales
    {
        protected static int codigo;
        protected static string especie;
        protected static string nombre;
        protected static double peso;
        protected static int jaula;
        
        //Propiedades

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public int Jaula
        {
            get { return jaula; }
            set { jaula = value; }
        }


        //Metodo

        public virtual string QueClasedeAnimalEres()
        {
            return "Soy un mamifero llamado" + nombre + 
                    "\n de especie "  + especie +
                    "\n peso en kg " + peso +
                    "\n estoy en la jaula " + jaula;
        }
    }
}
