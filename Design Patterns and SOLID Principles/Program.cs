using System;
using SOLID_Principles.OCP;

PaymentService paypal =
    new PaymentService(new PayPalPayment());

PaymentService upi =
    new PaymentService(new UPIPayment());

PaymentService card =
    new PaymentService(new CreditCardPayment());

paypal.MakePayment(100);

upi.MakePayment(200);

card.MakePayment(300);