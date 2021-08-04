using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.5);
            Console.WriteLine("Circle:");
            Console.WriteLine($"Площадь: {circle.CalcArea()}, Периметр: {circle.CalcPerimeter()}");

            Square square = new Square(4);
            Console.WriteLine("Square:");
            Console.WriteLine($"Площадь: {square.CalcArea()}, Периметр: {square.CalcPerimeter()}");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Triangle:");
            Console.WriteLine($"Площадь: {triangle.CalcArea()}, Периметр: {triangle.CalcPerimeter()}");

        }
    }
}
