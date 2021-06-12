using System;

namespace LesseonTwo
{
    internal class BaseGun : Weapon
    {
        public override int Damage => 2;

        public override void Fire() => Console.WriteLine("Бах!!!");
    }
}