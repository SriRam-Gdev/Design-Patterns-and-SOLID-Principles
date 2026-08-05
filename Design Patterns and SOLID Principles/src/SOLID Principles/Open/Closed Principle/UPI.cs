using System;

namespace SOLID_Principles.OCP
{
    public class UPIPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            // Logic to process UPI payment
            Console.WriteLine($"Processing UPI payment of {amount:C}");
        }
    }
}