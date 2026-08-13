using System;

namespace src.DesignPatterns.Creational.Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle ");
        }

        public Shape Duplicate()
        {
            var newRectangle = new Rectangle();
            newRectangle.Width = Width;
            newRectangle.Height = Height;
            return newRectangle;
        }
    }
}


