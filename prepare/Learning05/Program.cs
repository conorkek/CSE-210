using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red", 4);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Blue", 2, 4);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Pink", 5);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}. ");
        }
    }
}