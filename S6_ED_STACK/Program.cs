using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_ED_STACK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();

            //agregamos elementos al STACK
            my_stack.Push("upso");
            my_stack.Push("programacion");
            my_stack.Push("c#");
            my_stack.Push(5.5);

            

            foreach (var item in my_stack)
            {
                Console.WriteLine(item);
            }

            my_stack.Pop();
            Console.WriteLine("**************");

            foreach (var item in my_stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
