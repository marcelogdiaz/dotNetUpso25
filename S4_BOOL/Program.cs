using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_BOOL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valorB1=true;
            bool valorB2=false;

            //AND
            //T,F = F
            //F,T = F
            //F,F=F
            //T,T=T

            //AND
            if (valorB1 & valorB2)
            {
                Console.WriteLine("THEN");
            }
            else
            {
                Console.WriteLine("ELSE");
            }
            //----------------------------------

            //OR
            //T, F = T
            // F,T = T
            //F,F=F
            //T,T=T
            //OR
            if (valorB1 | valorB2)
            {
                Console.WriteLine("THEN");
            }
            else
            {
                Console.WriteLine("ELSE");
            }

            //XOR
            //T, F = T
            // F,T = T
            //F,F=F
            //T,T=F
            //XOR
            if (valorB1 ^ valorB2)
            {
                Console.WriteLine("THEN");
            }
            else
            {
                Console.WriteLine("ELSE");
            }

            //OPERADOR TERNARIO
            //if (valorB1 & valorB2)
            //{
            //    Console.WriteLine("THEN");
            //}
            //else
            //{
            //    Console.WriteLine("ELSE");
            //}

            Console.WriteLine((valorB1 & valorB2) ? "THEN" : "ELSE");

            ////PRECEDENCIA OPERADORES
            Console.WriteLine(true | true & false);   // output: True
            Console.WriteLine((true | true) & false); // output: False
        }
    }
}
