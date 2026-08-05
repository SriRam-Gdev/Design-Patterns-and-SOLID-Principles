using System;

namespace SOLID_Principles.OCP
{
    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            // Logic to process PayPal payment
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }
}