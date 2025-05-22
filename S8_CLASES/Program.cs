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
            
            
            List<Deportista> deportistasCenard = new List<Deportista>();

            JugadorFutbol j10 = new JugadorFutbol("Messi", "Lionel", 36, "delantero");
            Deportista dep = new Deportista("Rodriguez", "Juan", 41);

            deportistasCenard.Add(dep);
            deportistasCenard.Add(j10);


            ////armamos un equipo de futbol
            //List<JugadorFutbol> equipoLocal = new List<JugadorFutbol>();
            ////inicializar el equipo
            for (int i = 0; i < 12; i++)
            {
                deportistasCenard.Add(new JugadorFutbol($"ApLOCAL{i}", $"JLOCAL{i}", 25, i.ToString()));
            }

            deportistasCenard.Add(new Deportista("Loza", "Jose", 22));
            deportistasCenard.Add(new Deportista("Loza", "Ruben", 32));


            //Random valor = new Random();
            //int ivalor = valor.Next(0,12);
            ////mandar a precalentar a un jugador cualquiera
            //equipoLocal.ElementAt(ivalor).Precalentar();

            //j10.Precalentar();
            //j10.MiActividad();

            foreach (var item in deportistasCenard)
            {
                Console.Write($"Soy {item.Apellido}, {item.Nombre} - ");
                item.MiActividad();
                Console.WriteLine("-------------------");
            }

            Console.ReadLine();

        }
    }
}
