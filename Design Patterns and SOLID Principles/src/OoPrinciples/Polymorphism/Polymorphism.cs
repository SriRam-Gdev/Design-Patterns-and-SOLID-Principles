using System;
using System.Runtime.InteropServices;

class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }
    class Engine : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Engine is starting.");
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting.");
        }
    }

}