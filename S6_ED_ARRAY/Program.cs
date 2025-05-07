using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_ED_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaramos un arreglo de enteros
            int[] intArray;

            //alojar(reservar) memoria para 5 enteros
            intArray = new int[5]{ 1,20,30,40,50};
            //intArray = 
            //intArray[0] = 5;
            //intArray[1] = 5;
            //intArray[2] = 5;
            //intArray[3] = 5;
            //intArray[4] = 5;

            //intArray[5] = 5;
            
            //int i = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"El valor {i} del arreglo es {intArray[i]}");
            }

            Console.WriteLine("--------------------");

            int indice = 0;
            foreach (int i in intArray)
            {
                Console.WriteLine($"El valor {indice} del arreglo es {i}");
                indice++;
            }
            Console.WriteLine("--------------------");
            indice = 0;
            while (indice < intArray.Length)
            {
                Console.WriteLine($"El valor {indice} del arreglo es {intArray[indice]}");
                indice++;
            }

            Console.ReadLine();


        }
    }
}
