using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            int x = 1;
            //while (x <= 4)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //    ++x;
            //}

            //DO
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;

            //} while (x < 1);

            //FOR
            for (int i = 0; i < 5; i=i+2)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);

            //BUCLE INFINITO 
            for (int i = 0; i < 5; i=i-100)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
