using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    internal class Referi : Persona
    {
        public Referi(string apellido, string nombre, int edad) : base(apellido, nombre, edad)
        {
        }

        public override void MiActividad()
        {
            Console.WriteLine("Mi actividad es hacer cumplir el Reglamento. ");
        }
    }
}
