using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaramos una lista de enteros
            List<int> my_list = new List<int>();
            my_list.Add(11);
            my_list.Add(24);
            my_list.Add(13);
            my_list.Add(467);
            my_list.Add(52);

            List<string> my_other_list = new List<string>();

            Console.WriteLine($"La lista tiene {my_list.Count} elementos");

            Console.WriteLine($"El elemento en la posicion 3 es: {my_list[2]}");

            my_list[2] = 88;

            my_list.RemoveAt(4);

            //my_list.


            foreach (var item in my_list)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();

        }
    }
}
