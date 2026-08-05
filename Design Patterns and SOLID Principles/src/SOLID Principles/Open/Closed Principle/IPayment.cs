using System;

namespace SOLID_Principles.OCP
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }
}