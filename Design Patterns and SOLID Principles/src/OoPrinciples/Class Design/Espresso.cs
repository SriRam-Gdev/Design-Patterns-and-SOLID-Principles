using System;

namespace MyConsoleApp.src.OoPrinciples.ClassDesign
{
    public class Espresso : ICoffee
    {
        public void Prepare(IngredientInventory inventory)
        {
            if (inventory.HasIngredient("Water", 50) &&
                inventory.HasIngredient("Coffee", 20))
            {
                inventory.UseIngredient("Water", 50);
                inventory.UseIngredient("Coffee", 20);

                Console.WriteLine("Espresso is ready!");
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