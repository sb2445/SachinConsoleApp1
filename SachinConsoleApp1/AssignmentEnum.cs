using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    enum Year
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

    class AssignmentEnum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Here are the months in a year:");
            foreach (Year month in Enum.GetValues(typeof(Year)))
            {
                Console.WriteLine(month);
            }


            Year select = Year.December;
            Console.WriteLine("\nPassing enum value: " + select);


            if (select == Year.January)
            {
                Console.WriteLine("This is the starting month of the year.");
            }
            else if (select == Year.December)
            {
                Console.WriteLine("This is the ending month of the year.");
            }
            else
            {
                Console.WriteLine("This is a middle month of the year.");
            }
        }
    }
}
