using System;
using MyConsoleApp.src.OoPrinciples.ClassDesign;

class Program
{
    static void Main(string[] args)
    {
        CoffeeMachine machine = new CoffeeMachine();

        machine.ShowInventory();

        machine.MakeCoffee(new Espresso());
        machine.MakeCoffee(new Cappuccino());

        Console.WriteLine();
        Console.WriteLine("Remaining Ingredients:");

        machine.ShowInventory();
    }
}