using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class ControlStatementAssign
    {
        public static void Main()
        {
            int Number = 19;

            Console.WriteLine("_____Positive,Negetive,zero_____");
            if (Number == 0)
            {
                Console.WriteLine("Entered Number is Zero");
            }

            else if (Number > 0)
            {
                Console.WriteLine("Entered Number is Positive\n");
            }
            else
            {
                Console.WriteLine("Entered Number is Negative");
            }

            Console.WriteLine("____Grading____");
            int Marks = 61;
            if (Marks >= 91 && Marks <= 100)
            {
                Console.WriteLine("A Grade");
            }
            else if (Marks >= 71 && Marks <= 90)
            {
                Console.WriteLine("B Grade");
            }

            else if (Marks >= 61 && Marks <= 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (Marks >= 35 && Marks <= 60)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.WriteLine("____menu of Food Items___\n");
            int choice = 2;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Burger = 70 rs ");
                    break;
                case 2:
                    Console.WriteLine("Pizza = 250 rs");
                    break;
                case 3:
                    Console.WriteLine("Salad = 35 rs");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }

    }

}
