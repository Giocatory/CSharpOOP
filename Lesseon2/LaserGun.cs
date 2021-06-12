using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LesseonTwo
{
    class LaserGun : Weapon
    {
        public override int Damage => 5;

        public override void Fire() => Console.WriteLine("Бдыщ!!!");
    }
}