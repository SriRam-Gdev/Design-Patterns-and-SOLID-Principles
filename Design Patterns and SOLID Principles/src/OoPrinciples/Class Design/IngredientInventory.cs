using System;
using System.Collections.Generic;

namespace MyConsoleApp.src.OoPrinciples.ClassDesign
{
    public class IngredientInventory
    {
        private Dictionary<string, int> ingredients = new Dictionary<string, int>
        {
            { "Water", 1000 },
            { "Milk", 1000 },
            { "Coffee", 500 },
            { "Sugar", 300 }
        };

        public bool HasIngredient(string name, int quantity)
        {
            return ingredients.ContainsKey(name) &&
                   ingredients[name] >= quantity;
        }

        public void UseIngredient(string name, int quantity)
        {
            ingredients[name] -= quantity;
        }

        public void DisplayStock()
        {
            Console.WriteLine("Current Inventory:");

            foreach (var item in ingredients)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine();
        }
    }
}