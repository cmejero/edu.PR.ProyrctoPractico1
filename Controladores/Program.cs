using edu.PR.ProyectoPractico1.Servicios;
using edu.PR.ProyectoPractico1.Dtos;
namespace edu.PR.ProyectoPractico1.Controladores
{
    /// <summary>
    /// Clase principal de nuestra aplicacion
    /// </summary>
    internal class Program
    {

        public static string rutaFichero = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\FICHEROS\\Proyecto1\\";
        public static string rutaFicheroCLientes = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\FICHEROS\\Proyecto1\\ficheroCliente.txt";
        public static string rutaFicheroLog = String.Concat(rutaFichero, Utiles.Util.nombreFicheroLog());
        public static List<CLienteDto> listaClientes = new List<CLienteDto>();

        /// <summary>
        /// Metodo princiapl de entrada de nuestra aplicacion
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicherosInterfaz fi = new FicherosImplementacion();

            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionUsuario = mi.menuYSeleccion();

                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado cerrar aplicacion");
                            fi.escribirFicheroLog("Has seleccionado cerrar aplicacion");
                            fi.guardarEnFichero();
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("Has seleccionado opcion 1");
                            mi.accesoAOpcion1();
                            fi.escribirFicheroLog("Has seleccionado opcion 1");

                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado opcion 2");
                            fi.escribirFicheroLog("Has seleccionado opcion 2");

                            break;

                        case 3:
                            Console.WriteLine("Has seleccionado opcion 3");
                            fi.escribirFicheroLog("Has seleccionado opcion 3");

                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada es incorrecta");
                            fi.escribirFicheroLog("La opcion seleccionada es incorrecta");
                            break;


                    }
                } catch (Exception ex) { 
                
                    Console.WriteLine("Ha ocurrido un error, intentelo más tarde");
                    fi.escribirFicheroLog(String.Concat("Ha ocurrido un error: ", ex.Message , ";"));
                }




            } while (!cerrarMenu);





        }
    }
}
