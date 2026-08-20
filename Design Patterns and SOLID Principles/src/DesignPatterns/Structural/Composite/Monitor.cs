using System;
namespace DesignPatterns.Structural.Composite
{
    public class Monitor : Item
    {
        public float _price = 199.99f;
        public float GetPrice()
        {
            return _price;
        }
    }
}