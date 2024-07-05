using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    internal class ReverseArray
    {
        public static void Main(string[] args)
        {
            {
                string str = "CODEMIND TECHNOLOGY";
                Console.WriteLine("Given String"+str);
                string rev = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    rev = rev + str[i];
                }
                Console.WriteLine("Reversed String: " + rev);
            }


        }

    }
}
