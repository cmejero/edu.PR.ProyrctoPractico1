using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoPractico1.Servicios
{

    /// <summary>
    /// Clase que se encarga de mostrar los menus de nuestra aplicacion
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// MEtodo que se encarga de mostrar el menu principal de nuestro proyecto
        /// </summary>
        /// <returns></returns>
        public int menuYSeleccion();

        public void accesoAOpcion1();
    }
}
