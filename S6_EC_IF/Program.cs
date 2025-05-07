using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_IF
{
    internal class Program
    {
        /// <summary>
        /// Esta funcion permite COMPARAR dos strings. Es una funcion wrapper de 
        /// la comparacion ==
        /// </summary>
        /// <param name="s1">Un valor string a comparar</param>
        /// <param name="s2">Otro valor string a comparar</param>
        /// <returns>True si ambos parametros son iguales, caso contrario retorna
        /// False</returns>
        public static bool compararString(string s1, string s2) {
            //En este sentencia se realiza la comparacion de los parametros de entrada.
            //Es un wrapper que permite facilmente cambiar el criterio de comparacion
            //sin generar grandes cambios en el proyecto.
            return (s1==s2);
        }


        static void Main(string[] args)
        {
            string x = "UPSO C#";
            string y = "UPSO .NET";

            //if statement
            //if (x == y)
            if (compararString(x,y))
            {
                
                Console.WriteLine("Los strings son IGUALES");
            }
            else
            {
                Console.WriteLine("Los strings son DISTINTOS");
            }

            Console.ReadLine();

        }
    }
}
