using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class ArrayPrimeNo
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };


            //prints given array using foreach loop
            Console.Write("Given Array is:");
            foreach (int p in nums)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();

            //checks and prins the prime number  
            Console.Write("The prime numbers in the given array are: ");

            for (int i = 0; i < nums.Length; i++)
            {
                bool isPrime = true;

                if (nums[i] <= 1)
                {
                    isPrime = false;
                }
                else if (nums[i] == 2)
                {
                    isPrime = true;
                }
                else
                {
                    for (int j = 2; j < nums[i]; j++)
                    {
                        if (nums[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }


}













