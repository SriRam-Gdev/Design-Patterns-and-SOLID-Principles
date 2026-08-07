using System;
namespace SOLID_Principles.ISP

{
    public class Sword : IAttack
    {
        public void ExecuteAttack()
        {
            Console.WriteLine("Sword attack executed.");
        }
    }
}