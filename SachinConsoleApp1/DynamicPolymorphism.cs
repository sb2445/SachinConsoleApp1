using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    class Animal
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing A Shape");
        }
    }
    class Circle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
    class Rectangle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }


    }
    internal class DynamicPolymorphism
    {
        public static void Main()
        {
            Animal obj = new Animal();
            Animal obj2 = new Circle();
            Animal obj3 = new Rectangle();
            obj.Draw();
            obj2.Draw();
            obj3.Draw();
        }
    }
}

