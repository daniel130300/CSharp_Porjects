using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumentos
{
    public class Informacion_general
    {
        protected static string codigo, tipo, estilo, marca, fecha_compra, estado, observacion;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Fecha_compra
        {
            get { return fecha_compra; }
            set { fecha_compra = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public virtual string Mensaje()
        {
            return "Instrumento: " + tipo +
                   "\nTipo: " + estilo +
                   "\nMarca: " + marca +
                   "\nEstado: " + Estado +
                   "\nFecha Compra: " + fecha_compra +
                   "\nObservacion: " + observacion;
        }
    }
}
