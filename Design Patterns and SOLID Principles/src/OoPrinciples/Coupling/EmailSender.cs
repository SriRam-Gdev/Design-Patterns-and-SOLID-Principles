using System;
using MyConsoleApp.src.OoPrinciples.Coupling;


namespace OopPrinciples.Coupling;

class EmailSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}
