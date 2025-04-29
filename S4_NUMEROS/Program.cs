using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_S5_NUMEROS
{
    internal class Program
    {
        static void Main(string[] args)
        {   //RANGO DE VALORES 
            //Console.WriteLine($"int.MinValue = {int.MinValue}");
            //Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            //Console.WriteLine($"float.MinValue = {float.MinValue}");
            //Console.WriteLine($"float.MaxValue = {float.MaxValue}");
            //Console.WriteLine($"double.MinValue = {double.MinValue}");
            Console.WriteLine($"double.MaxValue = {double.MaxValue}");
            //Console.WriteLine($"decimal.MinValue = {decimal.MinValue}");
            Console.WriteLine($"decimal.MaxValue = {decimal.MaxValue}");
            //Console.WriteLine($"short.MinValue = {short.MinValue}");
            //Console.WriteLine($"short.MaxValue = {short.MaxValue}");
            //Console.WriteLine($"long.MinValue = {long.MinValue}");
            //Console.WriteLine($"long.MaxValue = {long.MaxValue}");

            //DECLARACION DE LITERALES
            //double numDouble = 3.78;
            //decimal numDecimal = 3.78M;
            //float numFloat = 3.78F;
            //int numInt;
            //numInt = (int) numDouble;
            //numInt = (int)numDecimal;

            //Console.WriteLine(numInt);

            //int i = 3;
            //Console.WriteLine("Valor Orignal de i: " + i);
            //Console.WriteLine("++i retorna: " + ++i);
            //Console.WriteLine("i++ retorna: "+ i++);
            //Console.WriteLine("Valor +i: " + +i);
            //Console.WriteLine("Valor final de i: " + i);
            

            //Console.WriteLine("-----------------------");

            //double d = 5.5;
            //Console.WriteLine("Valor Orignal de d: " + d);
            //Console.WriteLine("--d retorna: " + --d);
            //Console.WriteLine("d-- retorna: " + d--);
            //Console.WriteLine("Valor -d: " + -d);
            //Console.WriteLine("Valor final de d: " + d);


            Console.WriteLine(0.1m * 23.4M);
            float numero = 0.1f * 23.4F;
            Console.WriteLine(numero);
            Console.WriteLine(numero.GetType().Name);

            //valor INFINITO
            numero = (float.MaxValue) + 2;
            Console.WriteLine(numero);
            Console.WriteLine(numero.GetType().Name);
            //if (Double.IsInfinity(numero)) {
            //    Console.WriteLine("ES INFINITO");
            //}
            //else {
            //    Console.WriteLine("NO ES INFINITO");
            //}

            //El resultado de dividir por INFINITO, asume un valor 0
            Console.WriteLine(10 / numero);


            //Excepcion al dividir por 0. Error en tiempo de ejecucion
            int denominador = 0;
            Console.WriteLine(10 / denominador);

            double numeroD;
            numeroD= Convert.ToDouble(float.MaxValue) + 2;
            Console.WriteLine(numeroD);
            Console.WriteLine(numeroD.GetType().Name);
            //Console.WriteLine(0.1m * 23.4);

            //int j = i++;
            ////int j = i;
            ////i = i + 1;

            //int k = ++i;

            //Console.WriteLine($"i: {i}");
            //Console.WriteLine($"j: {j}");
            //Console.WriteLine($"k: {k}");

            //int l = 5;
            //l += 9;  //            l = l + 9;

            //Console.WriteLine($"l: {l}");

            //CAMMBIO DE PRECEDENCIA
            //int a = 20 / 10 / 2;
            //int b = 20 / (10 / 2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //if (a==b) {
            //    Console.WriteLine("A y B son iguales");
            //}
            //else { Console.WriteLine("A y B NO son iguales"); }

            //if (a != b)
            //{
            //    Console.WriteLine("A y B son distintos");
            //}
            //else { Console.WriteLine("A y B NO son distintos"); }



            Console.ReadLine();
        }
    }
}
