using System;

class Fruits
{
    public void Eat()
    {
        Console.WriteLine("Fruit is being eaten.");
    }

    public void Peel()
    {
        Console.WriteLine("Fruit is being peeled.");
    }

    class Apple : Fruits
    {

    }

    class Orange : Fruits
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruits apple = new Apple();
            apple.Eat();
            apple.Peel();

            Fruits orange = new Orange();
            orange.Eat();
            orange.Peel();
        }
    }
}