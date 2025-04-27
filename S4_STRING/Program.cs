using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_STRING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";
            b += "ello";

            //TIPO DE DATO POR REFERENCIA
            //Console.WriteLine(a == b);
            //Console.WriteLine(object.ReferenceEquals(a,b));

            
            string c = "algo";
            b = c;
            a = b;

            b = "otra cosa";

            Console.WriteLine(a);
            Console.WriteLine(object.ReferenceEquals(a, c));
            Console.ReadLine();
        }
    }
}
