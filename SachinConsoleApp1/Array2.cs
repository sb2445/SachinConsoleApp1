using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class Array2
    {
        public static void Main(string[] args)
        {
            int[] a = { 21, 22, 23, 24, 25, 26, 27, 28 };
            int smallest = a[0];
            int largest = a[0];
            Console.Write("Given Array:");

            //print Given Array
            foreach (int b in a)
            {
                Console.Write(b+" ");
            }
            Console.WriteLine("\n");

            //alternate array elements
            Console.Write("Alternated Array:");
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();


            //count array element
            Console.WriteLine("Number of elements in the array:" + a.Length);

            //smallest number and largest number
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < smallest)
                {
                    smallest = a[i];
                }
                if (a[i] > largest)
                {
                    largest = a[i];
                }

            }
            Console.WriteLine("smallest number in array: "+smallest);
            Console.WriteLine("largetest number in array: " +largest);
        }
    }
}
