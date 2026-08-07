using System;
namespace SOLID_Principles.ISP
{
    public class Gun : IAttack, IReload
    {
        public void ExecuteAttack()
        {
            Console.WriteLine("Gun attack executed.");
        }

        public void Reload()
        {
            Console.WriteLine("Gun reloaded.");
        }
    }

}
