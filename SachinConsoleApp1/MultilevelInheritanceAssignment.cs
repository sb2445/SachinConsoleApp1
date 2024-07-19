using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SachinConsoleApp1;

namespace SachinConsoleApp1
{
    // base class
    public class PersonP
    {
        public void Show()
        {
            Console.WriteLine("I am a Person ");
        }
    }
}

//derived class
public class Teacher : PersonP
{
    public void Diplay()
    {
        Console.WriteLine("I am a Teacher");
    }
}
//derived class
public class Principal : Teacher
{
    public void Screen()
    {
        Console.WriteLine("I am Principal");
    }
}
internal class MultilevelInheritanceAssignment
{

    public static void Main()
    {
        Principal obj = new Principal();
        obj.Show();
        obj.Diplay();
        obj.Screen();

    }
}

