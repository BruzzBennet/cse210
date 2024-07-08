using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(2,"red"));
        shapes.Add(new Rectangle(2,4,"blue"));
        shapes.Add(new Circle(2,"yellow"));

        foreach (Shape shape in shapes){
            Console.Write($"{shape.GetColor()} ");
            Console.WriteLine(shape.GetArea());
        }
    }
}