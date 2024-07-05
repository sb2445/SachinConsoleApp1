using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class StringBuilderAssignment2
    {
        public static void Main(string[] args)
        {
            int[] arr = { 50, 30, 80, 10, 40 };

            Console.Write("Given Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("\nMaximum value in the array: " + max);
            Console.WriteLine("Minimum value in the array: " + min);

        }
    }
}
