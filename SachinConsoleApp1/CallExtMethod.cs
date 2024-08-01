using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class CallExtMethod
    {
        static void Main()
        {
            BaseExtMethod obj = new BaseExtMethod();
            obj.Addition();
            obj.Substraction();
            obj.Multiplication();
            obj.Division();
        }
    }
}
