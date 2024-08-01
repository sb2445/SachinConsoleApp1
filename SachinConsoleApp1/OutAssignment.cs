using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class OutAssignment
    {
        static void Main(string[] args)
        {
            int number;
            string text;

            // Call the method to initialize the out parameters
            InitializeValue(out number, out text);

            // Display the values of the initialized variables
            Console.WriteLine("Initialized number: " + number);
            Console.WriteLine("Initialized text: " + text);
        }

        static void InitializeValue(out int num, out string txt)
        {
            // Assign values to the out parameters
            num = 100;
            txt = "Hello, World!";
        }
    }
}

