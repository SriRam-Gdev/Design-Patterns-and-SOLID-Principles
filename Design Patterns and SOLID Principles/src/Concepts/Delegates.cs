using System;

namespace src.Concepts.Delegates
{
    public delegate void BasicDelegate(string message);

    public class MessageService
    {
        public void SayHello(string message)
        {
            Console.WriteLine($"Hello: {message}");
        }

        public void SayGoodbye(string message)
        {
            Console.WriteLine($"Goodbye: {message}");
        }

        public void SayByeBye(string message)
        {
            Console.WriteLine($"Bye bye: {message}");
        }
    }
}