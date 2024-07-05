using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class ArrayAssignment
    {
        public static void Main(string[] args)
        {
            int [] a = { 34, 22, 34, 5,3,8,25 };
            int sum = 0;
            double average = 0;

            Console.Write("Given Array: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();

            for (int i = 0;i < a.Length; i++)
            {
                sum += a[i];
            }
            average = (double)sum / a.Length;

            Console.WriteLine("The sum of the given array is: " + sum);
            Console.WriteLine("The average of the given array is: "+average);

            




        }
    }
}
