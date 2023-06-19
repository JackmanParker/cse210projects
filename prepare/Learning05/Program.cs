using System;

namespace Learning5{
    class Program
{
    static void Main(string[] args)
    {
        Square testSquare = new Square("red", 5.5);
        Rectangle testRectangle = new Rectangle("blue", 5.5, 2.0);
        Circle testCircle = new Circle("green", 2.0);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(testCircle);
        shapes.Add(testRectangle);
        shapes.Add(testRectangle);


        Console.WriteLine($"The area of the square is {testSquare.GetArea()}, the color is {testSquare.GetColor()}");
        Console.WriteLine($"The area of the square is {testRectangle.GetArea()}, the color is {testRectangle.GetColor()}");
        Console.WriteLine($"The area of the square is {testCircle.GetArea()}, the color is {testCircle.GetColor()}");

        foreach (Shape shape in shapes){
            Console.WriteLine($"The area of the shape is {shape.GetArea()} and the color is {shape.GetColor()}");
        }
        
    }
}
}