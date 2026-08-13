using System;

namespace src.DesignPatterns.Creational.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle ");
        }

        public Shape Duplicate()
        {
            var newCircle = new Circle();
            newCircle.Radius = Radius;
            return newCircle;
        }
    }
}