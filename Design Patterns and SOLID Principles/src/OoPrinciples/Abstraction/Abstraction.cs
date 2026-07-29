using System;

namespace OopPrinciples.Abstraction;

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

public static class AbstractionDemo
{
    public static void Run()
    {
        Animal animal = new Dog();

        animal.MakeSound();
        animal.Sleep();
    }
}