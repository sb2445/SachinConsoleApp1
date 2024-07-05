using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class LoopAssign
    {
        public static void Main()
        {
            Console.WriteLine("-----For Loop------");
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Student Roll No: " + i);
            }

            Console.WriteLine("\n-----While Loop----");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("Student Roll No: " + j);
                j++;
            }
            Console.WriteLine("\n---do_While---");
            int k = 1;
            do
            {
                Console.WriteLine("Student Roll No: " + k);
                k++;
            }
            while (k <= 10);

            Console.WriteLine("\n___ Foreach_Loop--Mobile Brands--");
            string[] company = { "1.Apple", "2.Samsung", "3.Huawei", "4.Xiaomi;", "5.OnePlus", "6.Oppo", "7.Vivo", "8.Sony", "9.LG", "10.Motorola" };

            foreach (string MobileBrand in company)
            {  
                Console.WriteLine(MobileBrand); 
            }
        }
    }
}