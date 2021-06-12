using System;

namespace LesseonTwo
{
    internal class Bow : Weapon
    {
        public override int Damage => 3;

        public override void Fire() => Console.WriteLine("Пиу!!!");
    }
}