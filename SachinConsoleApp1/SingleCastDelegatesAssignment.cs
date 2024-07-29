using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    public delegate void AddDelegate(int a,int b);
    public delegate void SubDelegate(int p,int q);

    class DelegateEx
    { 
        public void Addition(int a,int b) 
        {
            Console.WriteLine($"Addition of {a} And {b} is: "+(a+b));
        }

        public void Substraction(int p, int q)
        {
            Console.WriteLine($"Substraction of {p} and {q} is: "+(p-q));
        }
    }
    internal class SingleCastDelegatesAssignment
    {
        public static void Main() 
        {
            DelegateEx cl = new DelegateEx();//object of class
            AddDelegate ad=new AddDelegate(cl.Addition);//object of Delegate
            ad(23,5);

            SubDelegate sb = new SubDelegate(cl.Substraction);
            sb(45, 5);
        }

    }
}
