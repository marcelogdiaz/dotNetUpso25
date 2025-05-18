using S8_CLASES.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona person1 = new Persona("Perez", "Juan",33);
            Persona person2 = new Persona("Rodriguez");

            Console.WriteLine($"{person1.Apellido} {person1.Nombre} tiene {person1.Edad} años.");

            person1.CumplirAnios();

            Console.WriteLine("Edad despues del cumpleaños...");
            Console.WriteLine($"{person1.Apellido} {person1.Nombre} tiene {person1.Edad} años.");
            


            Persona person3 = person2;

            person3.Edad = 25;
            Console.WriteLine("****************************");
            Console.WriteLine($"{person2.Apellido} {person2.Nombre} tiene {person2.Edad} años.");
            Console.WriteLine($"{person3.Apellido} {person3.Nombre} tiene {person3.Edad} años.");

            

            Console.ReadLine();
        }
    }
}
