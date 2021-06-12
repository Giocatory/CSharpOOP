using System;

namespace LesseonTwo
{
    internal class LaserGun : Weapon
    {
        public override int Damage => 5;

        public override void Fire() => Console.WriteLine("Бдыщ!!!");
    }
}