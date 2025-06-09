using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    internal class Deportista : Persona
    {
        public Deportista(string apellido, string nombre, int edad) : base(apellido, nombre, edad)
        {
        }

        public void Precalentar() {
            Console.WriteLine($"El DEPORTISTA {Apellido} esta precalentando con un trote suave.");
        }

        public virtual void Correr() {
            Console.WriteLine($"El DEPORTISTA {Apellido} esta corriendo a velocidad media.");
        }

        public  override void MiActividad() {
            Console.WriteLine("Mi actividad es el Deporte en greneral. ");
        }
    }
}
