using System;

namespace SOLID_Principles.LSP;

class Sword : IWeapon
{
    public void Fire()
    {
        Console.WriteLine("Sword is firing!");
    }
}
