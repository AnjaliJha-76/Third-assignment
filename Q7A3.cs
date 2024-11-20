using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    internal class Q7A3
    {
        public abstract class Shape
        {
            // Abstract method to calculate area
            public abstract double CalculateArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            // Constructor to initialize radius
            public Circle(double radius)
            {
                Radius = radius;
            }

            // Implementing CalculateArea for Circle
            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius; // Area = πr²
            }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            // Constructor to initialize width and height
            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            // Implementing CalculateArea for Rectangle
            public override double CalculateArea()
            {
                return Width * Height; // Area = width × height
            }
        }

            public static void Area()
            {
                // Create a Circle object
                Shape circle = new Circle(5.0);
                Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");

                // Create a Rectangle object
                Shape rectangle = new Rectangle(4.0, 6.0);
                Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():F2}");
            }
        }
    }

