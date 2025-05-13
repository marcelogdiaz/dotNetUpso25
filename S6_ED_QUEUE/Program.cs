using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_ED_QUEUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar una QUEUE
            Queue my_queue= new Queue();

            //agregamos elementos
            my_queue.Enqueue("UPSO");
            my_queue.Enqueue(1);
            my_queue.Enqueue(200);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("C#.NET");

            ////recorremos y mostramos los valores
            //foreach (var item in my_queue)
            //{
            //    Console.WriteLine(item);   
            //}

            //imprimimos la cantidad de elementos
            Console.WriteLine($"Total de elementos el QUEUE: {my_queue.Count}");
            
            Console.WriteLine($"El primer elemento es: {my_queue.Peek()}");
            
            var item2 = my_queue.Dequeue();

            Console.WriteLine($"El elemento eliminado es: {item2}");
            
            Console.WriteLine($"Total de elementos despues DEQUEUE: {my_queue.Count}");

            //recorremos y mostramos los valores
            foreach (var item in my_queue)
            {
                Console.WriteLine(item);
            }

            

            Console.ReadLine();
        }
    }
}
