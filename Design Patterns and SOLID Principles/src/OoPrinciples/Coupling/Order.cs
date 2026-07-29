using System;
using MyConsoleApp.src.OoPrinciples.Coupling;

namespace OopPrinciples.Coupling
{
    class Order
    {
        public void ProcessOrder()
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendNotification("Order processed successfully.");
        }
    }
}