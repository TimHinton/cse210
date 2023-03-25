using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        
        Square spongebob = new Square("yellow", 6);
        Console.WriteLine(spongebob.GetColor());
        Console.WriteLine(spongebob.GetArea());
        shapeList.Add(spongebob);

        Rectangle triangleMan = new Rectangle("orange", 2, 4);
        shapeList.Add(triangleMan);

        Circle universeMan = new Circle("black", 100);
        shapeList.Add(universeMan);

        foreach (Shape s in shapeList)
        {
            string whatColor = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"This shape is {whatColor} and the area is {area}");
        }
    }
}