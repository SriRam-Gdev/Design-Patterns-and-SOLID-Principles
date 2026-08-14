using System;
using src.DesignPatterns.Creational.Singleton;

class Program
{
    static void Main(string[] args)
    {
        // Get the singleton instance
        AppSettings settings1 = AppSettings.GetInstance();
        settings1.Set("theme", "dark");
        settings1.Set("maxRetries", 3);

        // Get it "again" from somewhere else in the app
        AppSettings settings2 = AppSettings.GetInstance();

        // Prove it's the SAME object
        Console.WriteLine(settings1 == settings2); // true

        // Even though we only called Set() on settings1,
        // settings2 sees the same data — because it's literally the same object.
        Console.WriteLine(settings2.Get("theme"));       // dark
        Console.WriteLine(settings2.Get("maxRetries"));  // 3
        Console.WriteLine(settings2.Get("nope"));        // (blank/null)
    }
}