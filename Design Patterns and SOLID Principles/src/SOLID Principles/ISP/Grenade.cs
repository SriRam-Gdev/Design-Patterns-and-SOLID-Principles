using System;
namespace SOLID_Principles.ISP
{
    public class Grenade : IThrowable
    {
        public void Throw()
        {
            Console.WriteLine("Grenade thrown.");
        }


    }
}