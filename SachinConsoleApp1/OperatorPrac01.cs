using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class OperatorPrac01
    {
        static void Main()
        {
            int a = 44;
            int b = 12;

            Console.WriteLine("Arithmetic Operator");
            int sum=(a+b);
            Console.WriteLine(sum);

            int sub=(a-b);
            Console.WriteLine(sub);

            int mul=(a*b);
            Console.WriteLine(mul);

            int div=(a/b);
            Console.WriteLine(div);

            int mod=(a%b);
            Console.WriteLine(mod);

            Console.WriteLine("Relational Operator");

            bool isEqual=(a==b);
            Console.WriteLine(isEqual);

            bool isNotEqual=(a!=b);
            Console.WriteLine(isNotEqual);

            bool isGreater=(a>b);
            Console.WriteLine(isGreater);

            bool isLess=(a<b);
            Console.WriteLine(isLess);

            bool isGreaterOrEqual=(a>=b);
            Console.WriteLine(isGreaterOrEqual);

            bool isLessOrEqual=(a<=b);
            Console.WriteLine(isLessOrEqual);

            Console.WriteLine("Logical Operater");

            Console.WriteLine(a > 30 && a < 40);
            Console.WriteLine(a > 30 || a < 40);
            Console.WriteLine(!(a < b));

        }
    }
}
