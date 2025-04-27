using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_STRUCT
{
    internal class Program
    {
        struct Coordenada {
            public int x;
            public int y;

            public Coordenada(int x, int b) { 
                this.x = x; 
                this.y = b;

            }
        }

        
        struct Persona {
            public string Nombre;
            public int Edad;
            public int Altura;
        }

        static void Main(string[] args)
        {
            //Coordenada point = new Coordenada(10, 20);

            //Console.WriteLine("X" + point.x);
            //Console.WriteLine("Y" + point.y);

            //point.x = 50;

            //Console.WriteLine("X" + point.x);
            //Console.WriteLine("Y" + point.y);

            Persona P1;
            P1.Altura = 180;
            P1.Edad = 25;
            P1.Nombre = "Juan";

            Persona P2;
            P2 = P1;
            Console.WriteLine($"{P1.Nombre} tiene {P1.Edad} años y mide {P1.Altura} cms.");
            //P2 se cambia el nombre
            P2.Nombre = "Martin";
            Console.WriteLine($"{P2.Nombre} tiene {P2.Edad} años y mide {P2.Altura} cms.");

            Console.ReadLine();
        }
    }
}
