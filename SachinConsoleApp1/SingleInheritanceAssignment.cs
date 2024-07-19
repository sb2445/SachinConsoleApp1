using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SachinConsoleApp1.Person;

namespace SachinConsoleApp1
{
    //Base Class
    public class Person
    {
        public void Name(string name)
        {
            Console.WriteLine($"Student Name:{name}");
        }


        public int Age(int age)
        {
            Console.WriteLine($"Student Age is:{ age}");
            return age;
           
        }

    }

    //Child Class
    public class Student : Person
    {

    }

    internal class SingleInheritanceAssignment
    {
        public static void Main()
        {
            Student obj = new Student();
            obj.Name("Ram");
            obj.Age(26);
        }
    }
}
