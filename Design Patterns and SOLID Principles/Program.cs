using System;
using SOLID_Principles.ISP;

Sword sword = new Sword();

Gun gun = new Gun();

Grenade grenade = new Grenade();

sword.ExecuteAttack();


gun.ExecuteAttack();
gun.Reload();

grenade.Throw();