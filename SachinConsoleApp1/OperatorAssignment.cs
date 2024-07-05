using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class OperatorAssignment
    {
        static void Main(string[] args)
        {
            //task:1 Arithmetic Operators
            int a = 25;
            int b = 5;

            int sum = (a + b);
            Console.WriteLine("Sum is:" + sum);

            int sub = (a - b);
            Console.WriteLine("Substration is:" + sub);

        int mul = (a * b);
            Console.WriteLine("Multiplication is:" + mul);

            int div = (a / b);
            Console.WriteLine("Quotient is:" + div);

        int mod = (a % b);
            Console.WriteLine("Remainder is:" + mod);

            //task:2 Relational Operators
            int c = 30;
            int d = 22;
            bool isEqual = (c == d);
            Console.WriteLine(isEqual);

            bool isNotEqual= (c != d);
            Console.WriteLine(isNotEqual);

            bool isGreater= (c > d);
            Console.WriteLine(isGreater);

            bool isLess= (c < d);
            Console.WriteLine(isLess);

            bool isGreaterOrEqual= (c >= d);
            Console.WriteLine(isGreaterOrEqual);

            bool isLessOrEqual= (c <= d);
            Console.WriteLine(isLessOrEqual);
            //task:3 Logical Operators
            int e = 100;
            int f = 50;
            Console.WriteLine(e < 120 && e > 40);    // Logical AND operator
            Console.WriteLine(e < 23 || e > 59);    //Logical OR Operator
            Console.WriteLine (!(e < f));           //Logical NOT Operator


        }
       

    }
}
