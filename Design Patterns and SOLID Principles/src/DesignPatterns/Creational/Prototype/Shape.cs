using System;

namespace src.DesignPatterns.Creational.Prototype
{
    public interface Shape
    {
        void Draw();
        Shape Duplicate();
    }
}