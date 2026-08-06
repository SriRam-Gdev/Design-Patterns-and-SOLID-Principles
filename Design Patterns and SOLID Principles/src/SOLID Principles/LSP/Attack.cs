using System;

namespace SOLID_Principles.LSP;

class Attack
{
    private readonly IWeapon weapon;

    public Attack(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public void ExecuteAttack()
    {
        this.weapon.Fire();
    }
}