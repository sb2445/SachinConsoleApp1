using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    public class Shape2
    {
       public void DisplayDetails(string color)
        {
        Console.WriteLine("color of The");
        }
        
    }
    public class Circle2 : Shape2
    {
       public void D()
        {
           // Console.WriteLine($"{color}");
        }
    }
    public class Rectangle2 : Shape2
    {
        public void DisoplayDetails(string color)
        {
            Console.WriteLine($"Rect{color}");
        }
    }
    internal class HierarchicalInheritanceAssignment
    {
        public static void Main()
        {
            Circle2 obj= new Circle2();
           // obj.DisoplayDetails("black");

            Rectangle2 obj2 = new Rectangle2();
            obj2.DisoplayDetails("yellow");
        }
    }
}
