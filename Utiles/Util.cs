using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoPractico1.Utiles
{
    /// <summary>
    /// Clase que se encarga de guardar metodos que serán utilizado más de una vez
    /// </summary>
    internal static class Util
    {
        /// <summary>
        /// Metodo que se encarga de construir el nombre del fichero Log
        /// </summary>
        /// <returns></returns>
        public static string nombreFicheroLog()
        {

            string nombreFichero = "";
            try
            {

                DateTime fechaActual = DateTime.Today;

                string fechaFormato = fechaActual.ToString("ddMMyyyy");

                nombreFichero = String.Concat("log-", fechaFormato, ".txt");



            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha producido un error, intentelo más tarde");

            }
            
                return nombreFichero;
            
        }

    }
}
