using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class ArrayListAssignment
    {
        public static void Main()
        {

            ArrayList obj = new ArrayList();
            obj.Add("Earth");
            obj.Add("Jupiter");
            obj.Add("Saturn");
            obj.Add("Neptune");
            obj.Add("Venus");
            obj.Add("Uranus");
            obj.Add("Mars");
            obj.Add("Mercury");
            obj.Add(false);
            obj.Add(98.7);

            Console.WriteLine("Elements present in Array:");
            foreach (var data in obj)
            {
                Console.WriteLine(data);
            }
            
            obj.Remove(true);
            obj.Remove(98.7);
            Console.WriteLine("\nBy using Remove Method (true)And(98.7) are removed Updated List:");
            foreach (var data in obj)
            {
                Console.WriteLine(data);
            }

            

        }
    }
}
