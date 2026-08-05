using System;

namespace SOLID_Principles.OCP
{
    public class PaymentService
    {
        private readonly IPayment paymentMethod;

        public PaymentService(IPayment paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount)
        {
            this.paymentMethod.ProcessPayment(amount);
        }
    }
}
