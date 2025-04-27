using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_ENUM
{
    internal class Program
    {
        enum WeekDays { 
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        enum Libros { 
            CSHARP,
            JAVASCRIPT,
            PYTHON,
            PHP,
            JAVA
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(WeekDays.SUNDAY);
            //Console.WriteLine((int )WeekDays.SUNDAY);

            //var dia = (WeekDays)3;
            //Console.WriteLine(dia);

            //var hoy = WeekDays.WEDNESDAY;

            //if (hoy == WeekDays.SATURDAY || hoy == WeekDays.SUNDAY) {
            //    Console.WriteLine("HOY ES FIN DE SEMANA");
            //}
            //else {
            //    Console.WriteLine("HOY es dia laboral.");
            //}

            Console.WriteLine($"Libro: PHP en el indice {(int)Libros.PHP}");
            Console.WriteLine($"Libro: Javascript en el indice {(int)Libros.JAVASCRIPT}");
            Console.WriteLine($"Libro: JAVA en el indice {(int)Libros.JAVA}");
            Console.WriteLine($"Libro: CSHARP en el indice {(int)Libros.CSHARP  }");
            Console.WriteLine($"Libro: PYTHON en el indice {(int)Libros.PYTHON}");


            Console.ReadLine();
        }
    }
}
