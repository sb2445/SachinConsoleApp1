using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class Operators
    {


        static void Main()
        {
            int a = 30;
            int b = 20;

            //Arithmetic Operator
            int sum = a + b;
            Console.WriteLine(sum);

            int sub = a - b;
            Console.WriteLine(sub);

            int mul=a* b;
            Console.WriteLine(mul);

            int div=a/ b;
            Console.WriteLine(div);
            int mod = a % b;
            Console.WriteLine(mod);

            //Conditional Operators
             int p = 20;
             int q = 23;
             string result = (p > q) ? "p is greater" : "q is greater";       
            Console.WriteLine(result);

            //Comparision Operator
            int r = 30;
            int s = 21;

            bool isEqual=(r== s);
            Console.WriteLine(isEqual);

            bool isNotEqual=(r!= s);  
            Console.WriteLine(isNotEqual);

            bool isGreator=(r> s);
            Console.WriteLine(isGreator);

            bool isLess=(r< s);
            Console.Write(isLess);

            bool isGreaterOrEqual=(r>=s);
            Console.WriteLine(isGreaterOrEqual);    

            bool isLessOrEqual=(r<=s);
            Console.WriteLine(isLessOrEqual);

        }
    }
}
