namespace MyConsoleApp.src.OoPrinciples.ClassDesign
{
    public class CoffeeMachine
    {
        private IngredientInventory inventory = new IngredientInventory();

        public void MakeCoffee(ICoffee coffee)
        {
            coffee.Prepare(inventory);
        }

        public void ShowInventory()
        {
            inventory.DisplayStock();
        }
    }
}