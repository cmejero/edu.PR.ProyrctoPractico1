using edu.PR.ProyectoPractico1.Controladores;
using edu.PR.ProyectoPractico1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoPractico1.Servicios
{

    /// <summary>
    /// CLase que se encarga de implementar a fichero interfaz
    /// </summary>
    internal class FicherosImplementacion : FicherosInterfaz
    {
        public void escribirFicheroLog(string mensaje)
        {

            StreamWriter st = null;
            try
            {
                st = new StreamWriter(Program.rutaFicheroLog, true);
                st.WriteLine(mensaje);


            }
            catch (IOException io)
            {
                Console.WriteLine("Se ha producido un error, intentelo más tarde");
            }
            finally
            {
                if(st != null)
                {
                    st.Close();
                }
            }
        }

        public void guardarEnFichero()
        {

            StreamWriter st = null;
            try
            {
                CLienteDto cliente1 = new CLienteDto();

                cliente1.Nombre = "carlos";
                cliente1.Apellido11 = "mejias";
                cliente1.Apellido21 = "romero";

                Program.listaClientes.Add(cliente1);


                foreach (CLienteDto cliente in Program.listaClientes) {

                    st = new StreamWriter(Program.rutaFicheroCLientes, true);
                    st.WriteLine(cliente);
                }


            }
            catch (IOException io)
            {
                Console.WriteLine("Se ha producido un error, intentelo más tarde");
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
            }

        }

        public void leerFichero()
        {


            StreamReader sr = null;

            try
            {

                sr = new StreamReader(Program.rutaFicheroCLientes);

                string lineas = "";
                while ((lineas = sr.ReadLine()) != null)
                {
                    string[] linea = lineas.Split(";");

                    CLienteDto cliente = new CLienteDto();

                    cliente.Nombre = linea[0];
                    cliente.Apellido11 = linea[1];
                    cliente.Apellido21 = linea[2];
                    
                    Program.listaClientes.Add(cliente);

                }

            }
            catch
            {



            }
            finally
            { 
            
            if(sr != null)
                { sr.Close(); }  
            }
        }



    }
}
