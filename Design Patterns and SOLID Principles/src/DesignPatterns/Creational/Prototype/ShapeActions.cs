using System;

namespace src.DesignPatterns.Creational.Prototype
{
    public class ShapeActions
    {
        public Shape DuplicateShape(Shape shape)
        {
            System.Console.WriteLine("Duplicating shape...");
            return shape.Duplicate();
        }
    }
}