using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTipos2
{
    internal class Program
    {
        /// <summary>
        /// Tipo de Dato ESTRUCTURA, Tipo de Dato por valor
        /// </summary>
        struct Book {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        }

        /// <summary>
        /// Tipo de Dato ENUMERADO, Tipo de Dato por valor
        /// </summary>
        enum Days { LUNES, MARTES,MIERCOLES,JUEVES,VIERNES,SABADO,DOMINGO}

        /// <summary>
        /// Ejemplo de pasaje de parametros por REFERENCIA
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        static int mifuncionPorReferencia( ref int param1, int param2) {

            param1 = param2 * 2;
            return param1;
        }

        /// <summary>
        /// Ejemplo de pasaje de parametros por VALOR
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        static int mifuncionPorValor( int param1, int param2)
        {

            param1 = param2 * 2;
            return param1;
        }

        static void Main(string[] args)
        {
            int resultado = 0;
            int val1 = 10;
            int val2 = 25;

            resultado = mifuncionPorValor(val1, val2);

            resultado = mifuncionPorReferencia(ref val1, val2);

            Console.WriteLine(resultado);
            Console.ReadLine();

            //Book miLibro = new Book();
            //miLibro.title = "Sistemas Operativos";
            //miLibro.author = "A. Silberchatz";
            //miLibro.subject = "Computacion";
            //miLibro.book_id = 1;

            //Console.WriteLine(miLibro.title);

            //Console.WriteLine("------------");
            //Console.WriteLine(miLibro);

            //Console.ReadLine();

            Console.WriteLine("Hoy es " + Days.MIERCOLES);
            Console.ReadLine();
        }
    }
}
