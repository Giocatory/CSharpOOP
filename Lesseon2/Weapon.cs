using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LesseonTwo
{
    abstract class Weapon
    {
        public abstract int Damage { get; }


        public abstract void Fire();

        public void GetInfo(Weapon weapon) => Console.Write($"Оружие: {weapon.GetType().Name}; Урон: {weapon.Damage}; Звук: ");
    }
}