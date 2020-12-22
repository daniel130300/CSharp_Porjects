using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumentos
{
    public class Viento:Informacion_general
    {

        private static string material;

        public Viento (string mat)
        {
            material = mat;
        }

        public override string Mensaje()
        {
            return "Instrumento: " + tipo +
                   "\nTipo: " + estilo +
                   "\nMarca: " + marca +
                   "\nEstado: " + Estado +
                   "\nMaterial: " + material + 
                   "\nFecha Compra: " + fecha_compra +
                   "\nObservacion: " + observacion;
        }
    }
}
