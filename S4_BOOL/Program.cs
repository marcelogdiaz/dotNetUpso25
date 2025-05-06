using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_S5_BOOL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool valorB1=true;
            //bool valorB2=false;

            ////Tabla de verdad AND
            ////T,F = F
            ////F,T = F
            ////F,F=F
            ////T,T=T

            ////AND
            //if (valorB1 & valorB2)
            //{
            //    Console.WriteLine("THEN");
            //}
            //else
            //{
            //    Console.WriteLine("ELSE");
            //}
            ////----------------------------------

            ////Tabla de verdad OR
            ////T, F = T
            //// F,T = T
            ////F,F=F
            ////T,T=T
            ////OR
            //if (valorB1 | valorB2)
            //{
            //    Console.WriteLine("THEN");
            //}
            //else
            //{
            //    Console.WriteLine("ELSE");
            //}

            ////Tabla de verdad XOR
            ////T, F = T
            //// F,T = T
            ////F,F=F
            ////T,T=F
            ////XOR
            //if (valorB1 ^ valorB2)
            //{
            //    Console.WriteLine("THEN");
            //}
            //else
            //{
            //    Console.WriteLine("ELSE");
            //}

            ////OPERADOR TERNARIO
            ////if (valorB1 & valorB2)
            ////{
            ////    Console.WriteLine("THEN");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("ELSE");
            ////}

            //Console.WriteLine((valorB1 & valorB2) ? "THEN" : "ELSE");

            //////PRECEDENCIA OPERADORES
            //Console.WriteLine(true | true & false);   // output: True
            //Console.WriteLine((true | true) & false); // output: False


            //ejemplo sobre operadores logicos
           //int edad = 11;
           // bool tieneDNI = true;

           // //si es mayor de edad y tiene dni, puede ingresar
           // //caso contrario, no puede ingresar

           // //if ((edad >=18) & tieneDNI) {
           // if ((edad >= 18) && tieneDNI)
           // {
           //         Console.WriteLine("Puede ingresar al local.");
           // }
           // else {
           //     Console.WriteLine("Ingreso denegado");
           // }


            bool tienePaseVIP = true;
            bool tieneTicketNormal = false;

            //si tiene un pase VIP o un ticket normal puede ingresar

            if (tienePaseVIP || tieneTicketNormal) {
                Console.WriteLine("Puede ingresar el evento.");
            }
            else {
                Console.WriteLine("NO Puede ingresar el evento.");
            }

        }
    }
}
