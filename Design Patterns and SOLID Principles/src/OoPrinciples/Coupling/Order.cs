using System;

namespace OopPrinciples.Coupling
{
    class Order
    {
        public void ProcessOrder()
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Order processed successfully.");
        }
    }
}