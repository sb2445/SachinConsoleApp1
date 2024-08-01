using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class HashSetAssignment
    {

        static void Main()
        {
            HashSet<int> obj1 = new HashSet<int> { 1,2,3,4,5 };

            Console.WriteLine("HashSet:1");
            foreach (int p in obj1)
            {
                Console.WriteLine(p);
            }

            obj1.Add(6);     //add 6 in current HashSet
            Console.WriteLine("\nAfter Adding 6 in Hashset:1");
            foreach (int p in obj1)
            {
                Console.WriteLine(p);
            }

            obj1.Remove(3);
            Console.WriteLine("\nAfter Removing 3 from HashSet");

            foreach (int p in obj1)
            {
                Console.WriteLine(p);
            }

            HashSet<int> obj2 = new HashSet<int> { 5,6,7,8 };   //another HashSet
            Console.WriteLine("\nHashSet:2");
            foreach (int p in obj2)
            {
                Console.WriteLine(p);
            }

            
            obj1 = new HashSet<int> { 1,2,3,4,5};
            obj1.UnionWith (obj2);
            Console.WriteLine("\nHashSet:1 UnionWith HashSet:2");
            foreach (int p in (obj1))
            {
                Console.WriteLine(p);
            }

            //intersection(reinitialize)
            obj1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            obj2 = new HashSet<int> { 5, 6, 7, 8 };


            
            obj1.IntersectWith(obj2);
            Console.WriteLine("\nHashSet:1 IntersectWith HashSet:2");
            foreach (int p in (obj1))
            {
                Console.WriteLine(p);
            }

        }


    }
}

