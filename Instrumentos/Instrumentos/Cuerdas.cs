using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumentos
{
    public class Cuerdas:Informacion_general
    {

        private static int numero;

        public Cuerdas(int num)
        {
            numero = num;
        }

        public override string Mensaje()
        {
            return "Instrumento: " + tipo + 
                   "\nTipo: " + estilo +
                   "\nMarca: " + marca +
                   "\nEstado: " + Estado +
                   "\nNumero de cuerdas: " + numero + 
                   "\nFecha Compra: " + fecha_compra +
                   "\nObservacion: " + observacion;
        }
    }
}
