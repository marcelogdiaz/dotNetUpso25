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
            //Persona person1 = new Persona("Perez", "Juan",33);
            //Persona person2 = new Persona("Rodriguez");

            //Console.WriteLine($"{person1.Apellido} {person1.Nombre} tiene {person1.Edad} años.");

            //person1.CumplirAnios();

            //Console.WriteLine("Edad despues del cumpleaños...");
            //Console.WriteLine($"{person1.Apellido} {person1.Nombre} tiene {person1.Edad} años.");

            //Persona person3 = person2;

            //person3.Edad = 25;
            //Console.WriteLine("****************************");
            //Console.WriteLine($"{person2.Apellido} {person2.Nombre} tiene {person2.Edad} años.");
            //Console.WriteLine($"{person3.Apellido} {person3.Nombre} tiene {person3.Edad} años.");

            Jugador j10 = new Jugador("Messi", "Lionel", 36, "delantero");

            //armamos un equipo de futbol
            List<Jugador> equipoLocal = new List<Jugador>();
            //inicializar el equipo
            for (int i = 0; i < 12; i++) {
                equipoLocal.Add(new Jugador($"ApLOCAL{i}", $"JLOCAL{i}",25, i.ToString()));
            }

            Random valor = new Random();
            int ivalor = valor.Next(0,12);
            //mandar a precalentar a un jugador cualquiera
            equipoLocal.ElementAt(ivalor).Precalentar();
            
            //j10.Precalentar();
            //j10.Correr();


            Console.ReadLine();
        }
    }
}
