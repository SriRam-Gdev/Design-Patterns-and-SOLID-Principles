using System;

namespace SOLID_Principles.LSP;

class Maze : IWeapon
{
    public void Fire()
    {
        Console.WriteLine("Maze is firing!");
    }
}