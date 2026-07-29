using System;

// Abstract class
abstract class Animal
{
    // Abstract method (no implementation)
    public abstract void MakeSound();

    // Normal method
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping...");
    }
}

// Child class
class Dog : Animal
{
    // Must implement MakeSound()
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Bark");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Dog();

        animal.MakeSound();
        animal.Sleep();
    }
}