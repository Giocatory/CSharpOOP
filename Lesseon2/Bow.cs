using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LesseonTwo
{
    class Bow : Weapon
    {
        public override int Damage => 3;

        public override void Fire() => Console.WriteLine("Пиу!!!");
    }
}