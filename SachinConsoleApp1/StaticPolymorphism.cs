using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    class Calculator
    {
        public int Add(int p, int q)
        {
            return p + q;

        }

        public double Add(double p, double q)
        {
            return q - p;

        }

        public int Sub(int p, int q)
        {
            return q - p;
        }

        public double Sub(double p, double q)
        {
            return q - p;
        }

        public int Prod(int p, int q)
        {
            return p * q;
        }

        public double Prod(double p, double q)
        {
            return q * p;
        }

        public int Div(int p, int q)
        {
            return p / q;
        }

        public double Div(double p, double q)
        {
            return q / p;
        }
    }
    internal class StaticPolymorphism
    {
        public static void Main()
        {
            Calculator obj = new Calculator();

            int iadd = obj.Add(6, 4);
            double dadd = obj.Add(3.5, 9.2);

            int isub = obj.Sub(22, 33);
            double dsub = obj.Sub(101.3, 115.6);

            int iprod = obj.Prod(12, 8);
            double dprod = obj.Prod(46.2, 23.3);

            int idiv = obj.Div(12, 6);
            double ddiv = obj.Div(81.7, 16);






            Console.WriteLine("Addition of integer is:" + iadd);
            Console.WriteLine("Addition of double is:" + dadd);
            Console.WriteLine("Substraction of integer is:" + isub);
            Console.WriteLine("Substraction of double is:" + dsub);
            Console.WriteLine("Product of integer is:"+iprod);
            Console.WriteLine("Product of double is:"+dprod);
            Console.WriteLine("Divisision of integer is:" + idiv);
            Console.WriteLine("Division of double is:"+ddiv);


        }
    }
}
