using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class RefAssignment
    {
        public static void IncrementValue(ref int i)
        {
            i++;
        }
        public static void Main()
        {
            int m = 97;

            Console.WriteLine($"Given Number m={m}");
            IncrementValue(ref m);
            Console.WriteLine($"After Increment by 1 m={m}");
        }
    }
}
