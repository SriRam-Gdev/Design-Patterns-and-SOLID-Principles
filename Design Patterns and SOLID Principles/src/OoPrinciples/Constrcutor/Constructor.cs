using System;

namespace MyConsoleApp.src.OoPrinciples.Constructor
{
    public class Constructor
    {
        private readonly string name;
        private readonly int age;

        public Constructor(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}