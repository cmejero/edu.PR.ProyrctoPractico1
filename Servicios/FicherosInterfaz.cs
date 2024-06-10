using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoPractico1.Servicios
{
    /// <summary>
    /// Clase que se encarga de los metodos relacionados con ficheros
    /// </summary>
    internal interface FicherosInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de escribir en fichero log los errores y las opciones indicadas
        /// </summary>
        /// <param name="mensaje">enviar suceso del error o opciones indicadas</param>
        public void escribirFicheroLog(string mensaje);

        public void guardarEnFichero();
    }
}
