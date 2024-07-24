using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class HashtableAssignment
    {

        static void Main()
        {
            Hashtable myHashtable = new Hashtable();

            myHashtable.Add(1, "Suresh");
            myHashtable.Add(2, "Mahesh");
            myHashtable.Add(3, "Alok");
            myHashtable.Add(4, "Kushal");
            myHashtable.Add(5, "Naksh");

            Console.WriteLine("________Original Contents:_______");
            foreach (DictionaryEntry p in myHashtable)
            {
                Console.WriteLine($"{p.Key}:{p.Value}");
            }


            Console.WriteLine("________After Modify__2.Mahesh is replaced by 2.Yash________");
            myHashtable[2] = "Yash";

            foreach (DictionaryEntry p in myHashtable)
            {
                Console.WriteLine($"{p.Key}:{p.Value}");
            }

            Console.WriteLine("________After Removing__________");
            myHashtable.Remove(1);
            myHashtable.Remove(2);

           foreach(DictionaryEntry p in myHashtable)
            {
                Console.WriteLine($"{p.Key}:{p.Value}");
            }
        }
    }

}