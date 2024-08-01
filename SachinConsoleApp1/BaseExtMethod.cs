using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{ 
    public class BaseExtMethod
    {
        public int x = 2, y = 5, z = 30;
                                                      
        
        public void Addition() 
        {
            Console.WriteLine("Base Class Method:");
            Console.WriteLine($"Three numbers are x= {x},y={y} and z= {z}");
            Console.WriteLine($"Addition is of given numbers x+y+z = {this.x + this.y + this.z}");
        }
       
    }
}
