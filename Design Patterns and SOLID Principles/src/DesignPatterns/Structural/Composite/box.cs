using System;

namespace DesignPatterns.Structural.Composite
{
    public class Box : Item
    {
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public float GetPrice()
        {
            float totalPrice = 0;
            foreach (Item item in _items)
            {
                totalPrice += item.GetPrice();
            }
            return totalPrice;
        }
    }
}
