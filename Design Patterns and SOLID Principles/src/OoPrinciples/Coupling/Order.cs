using System;
using MyConsoleApp.src.OoPrinciples.Coupling;

namespace OopPrinciples.Coupling
{
    class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void ProcessOrder()
        {
            // Order processing logic here
            Console.WriteLine("Order processed successfully.");
            notificationService.SendNotification("Your order has been processed.");
        }
    }
}