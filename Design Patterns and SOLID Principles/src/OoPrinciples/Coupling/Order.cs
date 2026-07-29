using System;

namespace OoPrinciples.Encapsulation.Coupling
{
    class Order
    {
        private EmailSender emailSender;

        public Order(EmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public void PlaceOrder(string orderDetails)
        {
            // Logic to place the order
            Console.WriteLine("Order placed: " + orderDetails);

            // Send confirmation email
            emailSender.SendEmail("Your order has been placed successfully.");
        }
    }
}