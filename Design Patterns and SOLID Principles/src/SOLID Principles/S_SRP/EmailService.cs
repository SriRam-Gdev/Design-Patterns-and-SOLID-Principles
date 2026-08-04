using System;

namespace SOLID_Principles.S_SRP
{
    class EmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Email sent to {email}");
        }
    }
}