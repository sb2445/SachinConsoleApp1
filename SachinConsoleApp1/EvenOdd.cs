using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class EvenOdd
    {
        public static void Main(string[] args)
        {

            int[] numbers = { 22, 36, 11, 95, 23, 6, 20, 100, 101 };

            int evenCount = 0;
            int oddCount = 0;

            Console.Write("The Given Numbers are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }
            Console.WriteLine();

            Console.Write("Even numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(" " + numbers[i]);
                    evenCount++;
                }
            }
            Console.WriteLine($"\nTotal even numbers: " + evenCount);

            Console.Write("\nOdd numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(" " + numbers[i]);
                    oddCount++;
                }
            }
            Console.WriteLine("\nTotal odd numbers: " + oddCount);
        }
    }

}



