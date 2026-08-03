using System;

namespace MyConsoleApp.src.OoPrinciples.ClassDesign
{
    public class Cappuccino : ICoffee
    {
        public void Prepare(IngredientInventory inventory)
        {
            if (inventory.HasIngredient("Water", 50) &&
                inventory.HasIngredient("Coffee", 20) &&
                inventory.HasIngredient("Milk", 100))
            {
                inventory.UseIngredient("Water", 50);
                inventory.UseIngredient("Coffee", 20);
                inventory.UseIngredient("Milk", 100);

                Console.WriteLine("Cappuccino is ready!");
            }
            else
            {
                Console.WriteLine("Not enough ingredients.");
            }
        }

        public void prepare(IngredientInventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}