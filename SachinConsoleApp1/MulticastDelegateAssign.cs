using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    public delegate void ArithOpr(int x, int y);
    class DelegateEx2
    {
        public void Addition(int x, int y)
        {
            
            Console.WriteLine($"Addition of {x} And {y} is: "+(x+y));
        }

        public void Substraction(int x, int y)
        {
            Console.WriteLine($"Substraction of {x} And {y} is: " +( x - y));
            

        }

        public void Multiplication(int x, int y)
        {
           
            Console.WriteLine($"Multiplication of {x} And {y} is: " +( x * y));

        }


    }

    internal class MulticastDelegateAssign
    {
        public static void Main()
        {                                                           
            DelegateEx2 cl = new DelegateEx2();
            ArithOpr ar=cl.Addition;
            ar(67, 4);
            ar =cl.Substraction;
            ar(45, 6);
            ar=cl.Multiplication;
            ar(56, 8);




        }
    }
}


