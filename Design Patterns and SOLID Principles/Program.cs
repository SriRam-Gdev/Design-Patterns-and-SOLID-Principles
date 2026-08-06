using System;
using SOLID_Principles.LSP;

Attack attack = new Attack(new Sword());
attack.ExecuteAttack();
attack = new Attack(new Maze());
attack.ExecuteAttack();
