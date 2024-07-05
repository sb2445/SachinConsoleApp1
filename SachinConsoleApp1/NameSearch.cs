using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SachinConsoleApp1
{
    internal class NameSearch
    {
        public static void Main(string[] args)
        {
            string[] Names = { "Alice", "Bob", "Charlie", "David", "Emily" };
            string search = "Mahesh";

            Console.WriteLine("Given Array: ");
            foreach (string name in Names)
            {
                Console.WriteLine(name);

            }
            bool found = Names.Contains(search);
            if (found)
            {
                Console.WriteLine("The Entered string "+search+" is present in The Array");
            }
            else
            {
                Console.WriteLine("The Entered string " + search+ " is not in the Array");


            }

        }
    }
}