using System;

namespace OopPrinciples.Coupling;

class EmailSender
{
    public void SendEmail(String Message)
    {
        Console.WriteLine("Email sent: " + Message);
    }
}
