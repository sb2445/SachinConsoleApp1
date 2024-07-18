using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
   

    public abstract class Shape
    {
        // Abstract method to calculate the area of the shape
        public abstract double CalculateArea();

        // Non-abstract method to display the shape type
        public virtual void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    class Rectangle1 : Shape
    {
        // Properties for the dimensions of the rectangle
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor to initialize the dimensions
        public Rectangle1(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Override the CalculateArea method to provide the specific formula for a rectangle
        public override double CalculateArea()
        {
            return Length * Width;
        }

        // Optionally, override the Display method to include additional information about the shape
        public override void Display()
        {
            Console.WriteLine($"This is a rectangle with length {Length} and width {Width}. Its area is {CalculateArea()}.");
        }
    }

    public class Circle1 : Shape
    {
        // Property for the radius of the circle
        public double Radius { get; set; }

        // Constructor to initialize the radius
        public Circle1(double radius)
        {
            Radius = radius;
        }

        // Override the CalculateArea method to provide the specific formula for a circle
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Optionally, override the Display method to include additional information about the shape
        public override void Display()
        {
            Console.WriteLine($"\nThis is a circle with radius {Radius}. Its area is {CalculateArea()}.\n");
        }
    }

    

    internal class AbstractAssignment
    {
        public static void Main() 
        {

            // Create a rectangle and display its information
            Shape rectangle = new Rectangle1(5, 3);
            rectangle.Display();

            // Create a circle and display its information
            Shape circle = new Circle1(4);
            circle.Display();

        }
    }
}
