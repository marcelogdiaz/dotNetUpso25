using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_ED_JAGGED_ARAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar un jagged array de 4 elementos
            int[][] jagged_arr = new int[4][];
            /*
            [] ={ 1, 2, 3, 4 }
            [] ={ 11, 34, 67 }
            [] ={ 89, 23 }
            [] ={ 0, 45, 78, 53, 99 }
             * 
             * */

            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            for (int i = 0; i < jagged_arr.Length; i++)
            {//bucle de 4 iteraciones
             ////imprimrir en que fila estoy
                Console.Write($"Fila {i} = ");
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    //imprimo el elemento
                    Console.Write($" {jagged_arr[i][j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine(); 
        }
    }
}
