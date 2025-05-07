using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string materia = "C#";

            //switch (materia)
            //{
            //    case "JAVA":
            //        Console.WriteLine("La materia es JAVA.");
            //        break;
            //    case "C#":
            //        Console.WriteLine("La materia es C#.");
            //        break;
            //    case "PHP":
            //        Console.WriteLine("La materia es PHP.");
            //        break;
            //    case "PYTHON":
            //        Console.WriteLine("La materia es PYTHON.");
            //        break;
            //    default:
            //        Console.WriteLine($"La materia es {materia}");
            //        break;
            //}


            //decimal valor = 1;
            //switch (valor)
            //{
            //    case 0:
            //        Console.WriteLine("El valor es CERO.");
            //        break;
            //    default:
            //        if (valor > 2.0m) { 
            //            Console.WriteLine("El valor es mayor que 2.0.");
            //        }
            //        else {
            //            Console.WriteLine("El valor es menor o igual que 2.0.");
            //        }
            //        break;
            //}

            string topic, category;
            topic = "inheritance";

            switch (topic)
            {
                case "introductionto c#":
                case "variables":
                case "data types":
                    category = "BASIC";
                    break;

                case "loops":
                case "if statements":
                case "jump statements":
                    category = "CONTROL FLOW";
                    break;

                case "class & objects":
                case "inheritance":
                case "constructors":
                    category = "OOPS CONCEPTS";
                    break;

                default:
                    category = "UNKNOWN";
                    break;
            }

            Console.WriteLine($"La categoria es : {category}");
            Console.ReadLine();
        }
    }
}
