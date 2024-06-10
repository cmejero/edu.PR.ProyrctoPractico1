using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoPractico1.Servicios
{

    /// <summary>
    /// Clase que implementa en menu interfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        FicherosInterfaz fi =  new FicherosImplementacion();

        public int menuYSeleccion() {

            int opcionUsuario;

            Console.WriteLine("###################");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1.Opcion 1");
            Console.WriteLine("2.Opcion 2");
            Console.WriteLine("3.Opcion 3");
            Console.WriteLine("###################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;


        }
    

    private int menuYSeleccionOpcion1()
    {
        int opcionUsuario;

        Console.WriteLine("###################");
        Console.WriteLine("0.Volver");
        Console.WriteLine("1.Opcion 1.1");
        Console.WriteLine("2.Opcion 1.2");
        Console.WriteLine("3.Opcion 1.3");
        Console.WriteLine("###################");

        opcionUsuario = Convert.ToInt32(Console.ReadLine());
        return opcionUsuario;


    }



        public void accesoAOpcion1()
        {
            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionUsuario = menuYSeleccionOpcion1();

                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado volver");
                            fi.escribirFicheroLog("Has seleccionado volver");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("Has seleccionado opcion 1.1");
                            fi.escribirFicheroLog("Has seleccionado opcion 1.1");

                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado opcion 1.2");
                            fi.escribirFicheroLog("Has seleccionado opcion 1.2");

                            break;

                        case 3:
                            Console.WriteLine("Has seleccionado opcion 1.3");
                            fi.escribirFicheroLog("Has seleccionado opcion 1.3");

                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada es incorrecta");
                            fi.escribirFicheroLog("La opcion seleccionada es incorrecta");
                            break;


                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ha ocurrido un error, intentelo más tarde");
                    fi.escribirFicheroLog(String.Concat("Ha ocurrido un error: ", ex.Message, ";"));
                }




            } while (!cerrarMenu);

        }
    }
}
