using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class DictionaryAssignment
    {
        static void Main()
        {
            Dictionary<String, int> obj = new Dictionary<String, int>();
            obj.Add("Aryan", 35000);
            obj.Add("Suraj", 29500);
            obj.Add("Anika", 52000);
            obj.Add("Layla", 20000);
            obj.Add("Sarah", 35350);
            obj.Add("Manav", 49500);
            obj.Add("Amira", 62000);
            obj.Add("Priya", 25000);
            obj.Add("Vikas", 39000);
            obj.Add("Naina", 44000);

            Console.WriteLine("Name And Monthly salary of employees:");

            foreach (KeyValuePair<String, int> information in obj)
            {
                Console.WriteLine($"{information.Key}:{information.Value}");
            }

            //modified
            obj["Aryan"] = 65000;
            obj["Naina"] = 23000;

            Console.WriteLine("\nAryan and Naina's salaries have been updated:");
            foreach (KeyValuePair<String, int> information in obj)
            {
                Console.WriteLine($"{information.Key}:{information.Value}");
            }

            //remove
            obj.Remove("Vikas");
            Console.WriteLine("\nThe emploee name Vikas is removed:");

            foreach (KeyValuePair<String, int> information in obj)
            {
                Console.WriteLine($"{information.Key};{information.Value}");
            }

            //checking name is prent in list or not
            if (obj.ContainsKey("Vikas"))
            {
                Console.WriteLine("\nThe name Vikas is present");
            }
            else
            {
                Console.WriteLine("\nThe name Vikas is not present");
            }

            //clear dictionary
            obj.Clear();

            if(obj.Count==0)
            {
                Console.WriteLine("\nAfter clearing Dictionary :Dictionary is empty");
            }
            else
            {
                Console.WriteLine("\nAfter clearing Dictionary :Dictionary is  not empty");
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
