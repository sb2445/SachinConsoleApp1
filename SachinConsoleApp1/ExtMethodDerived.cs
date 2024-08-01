using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    public static class ExtMethodDerived
    {
        
        public static void Substraction(this BaseExtMethod o)
        {
            Console.WriteLine("\nDerived Class Methods:");
            Console.WriteLine($"Substraction of z-y-x is: {o.z - o.y - o.x}");
        }

        public static void Multiplication(this BaseExtMethod o)
        {

            Console.WriteLine($"Multiplication of x*y*z =  {o.x * o.y * o.z}");
        }

        public static void Division(this BaseExtMethod o)
        {
            Console.WriteLine($"Division of z/y/x = {o.z/o.y/o.x}");

        }
    }
}
