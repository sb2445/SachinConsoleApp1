using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SachinConsoleApp1
{
    internal class StringBuilderAssignment1
    {
      

        public static void Main(string[] args)
        {
             StringBuilder p = new StringBuilder();

            Console.WriteLine(" Task:1 Initialize a StringBuilder object & Append Multiple Strings to it");
            p.Append("Hi ");
            Console.WriteLine(p);
            p.Append("Hello ");
            Console.WriteLine(p);
            p.Append("How Are You?");
            Console.WriteLine(p);
            Console.WriteLine("\nTask:2 Replace a specific substring within the StringBuilder");
            Console.WriteLine(p);
            p.Replace("Hello", "Sachin");
            Console.WriteLine(p);
            Console.WriteLine("Hello is Replaced by Sachin");
            Console.WriteLine("\nTask:3 Remove a portion of the StringBuilder using the Remove method");
            Console.WriteLine(p);
            p.Remove(3, 7);
            Console.WriteLine(p);
            Console.WriteLine("Sachin is removed");





        }
    }
}
