using System;

namespace DesignPatterns.Structural.Composite
{
    public class Mouse : Item
    {
        public float _price = 19.99f;
        public float GetPrice()
        {
            return _price;
        }
    }
}