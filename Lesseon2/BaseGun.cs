using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LesseonTwo
{
    class BaseGun : Weapon
    {
        public override int Damage => 2;

        public override void Fire() => Console.WriteLine("Бах!!!");
    }
}