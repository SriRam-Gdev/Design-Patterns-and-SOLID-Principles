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


}