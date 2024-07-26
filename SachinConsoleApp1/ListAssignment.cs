using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class ListAssignment
    {
        static void Main()
        {
            List<string> myList = new List<string>();
            Console.WriteLine("List of colors:");
            myList.Add("Black");
            myList.Add("Blue");
            myList.Add("Pink");                               //created List
            myList.Add("White");
            myList.Add("Red");

            foreach (String colors in myList)
            {

                Console.WriteLine(colors);
            }

            myList.Remove("Red");
            myList.Remove("Pink");                                     //Removed
            Console.WriteLine("\nRed and pink are removed:");
            foreach (String colors in myList)
            {

                Console.WriteLine(colors);
            }

            myList.Add("Yellow");                                   //inserted
            myList.Add("Gray");
            Console.WriteLine("\nYellow and Gray are added:");
            foreach (String colors in myList)
            {

                Console.WriteLine(colors);
            }

            myList.Clear();
            if (myList.Count==0) 
            {
                Console.WriteLine("\nList is cleared\n\n");
            }

        }

    }
}

