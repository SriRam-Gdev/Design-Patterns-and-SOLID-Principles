using System;
namespace src.Concepts.DesignPatterns.Creational.AbstractFactory.Mac
{

    public class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render button");
        }
    }
}