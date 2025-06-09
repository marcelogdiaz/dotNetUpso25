using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S8_CLASES.Entidades
{
    internal class JugadorHockey : Deportista
    {
        public JugadorHockey(string apellido, string nombre, int edad) : base(apellido, nombre, edad)
        {
        }

        public override void MiActividad()
        {
            Console.WriteLine("Mi actividad es el Hockey sobre césped. ");
        }
    }
}