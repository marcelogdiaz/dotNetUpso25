using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_VariablesYConstantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////declaracion de variables
            //int variable1;

            ////inicializacion de variables
            //variable1 = 10;

            ////declaracion e inicializacion de variable
            //int variable2 = variable1 + 20;

            //float variable3 = 10.5F;

            ////declaracion de variable mediante VAR
            //var variableVAR = variable2;

            ////variableVAR = "UPSO"; //ERROR en compilacion porque asume el valor de variable2

            ////variableVAR =  variable3; ///ERROR conversion implicita
            //variableVAR = (int)variable3;

            //Console.WriteLine(variableVAR);
            //Console.WriteLine(variableVAR.GetType().ToString());
            //Console.ReadLine();

            //constantes
            const int VALORCONSTANTE = 1000;
            const double PI = 3.1415;
            const string UNI = "UPSO";
            const string NOMBREAPP = "SIRIUS";

            Console.Write(NOMBREAPP);
            Console.ReadLine() ;

        }
    }
}
