using System;

class Program
{
    static void Main(string[] args)
    {
        // define variables
        List<Shape> shapes = new List<Shape>();

        // Square:
        Square square = new Square ("blue", 5.0);
        shapes.Add(square);

        // Rectangle:
        Rectangle rectangle = new Rectangle ("red", 3.0, 4.0);
        shapes.Add(rectangle);

        // Circle:
        Circle circle = new Circle ("green", 6.0);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}