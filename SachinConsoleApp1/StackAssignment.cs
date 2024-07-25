using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class StackAssignment
    {
        static void Main()
        {
            Stack obj = new Stack();

            obj.Push("Mobile");
            obj.Push("Fridge");
            obj.Push("Lamp");
            obj.Push("Laptop");
            obj.Push("TV");

            Console.WriteLine("Given List:-");
            foreach (var item in obj)
            {
                Console.WriteLine("                "+item);
            }
            Console.WriteLine();
            object thirdelement=obj.Pop();
            object fourthelement=obj.Pop();
            object fifthelement=obj.Pop();
            Console.WriteLine("updated List:-");
            foreach (var item in obj)
            {
                Console.WriteLine("                 "+item);
            }

            Console.WriteLine("\n");


        }
    }
}
