using System;
namespace DesignPatterns.Structural.Composite
{
    public class Keyboard : Item
    {
        public float _price = 29.99f;
        public float GetPrice()
        {
            return _price;
        }
    }
}