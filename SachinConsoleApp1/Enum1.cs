using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{

    public enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class Enum1
    {

        public void show()
        {
            Console.WriteLine("This is show method");
        }

        public static void Main(string[] args)
        {
            Enum1 obj =new Enum1();
            obj.show();
            foreach (Months month in Enum.GetValues(typeof(Year)))
            {
                Console.WriteLine(month);
            }

        }
    }
}
