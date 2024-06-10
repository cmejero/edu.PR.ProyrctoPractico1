using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoPractico1.Dtos
{
    internal class CLienteDto
    {
        long id;
        string nombre = "aaaaaa";
        string Apellido1 = "aaaaaa";
        string Apellido2 = "aaaaaa";

        public CLienteDto(long id, string nombre, string apellido1, string apellido2)
        {
            this.id = id;
            this.nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido11 { get => Apellido1; set => Apellido1 = value; }
        public string Apellido21 { get => Apellido2; set => Apellido2 = value; }


        public CLienteDto() { }


        override
            public string ToString()
        {
            string toString = String.Concat("Nombre: ", Nombre, " Apellido1: ", Apellido11, " Apellido2: ", Apellido21);
            return toString;
        }
    }
}
