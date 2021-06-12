using System;

namespace LesseonTwo
{
    internal abstract class Weapon
    {
        public abstract int Damage { get; }

        public abstract void Fire();

        public void GetInfo(Weapon weapon) => Console.Write($"Оружие: {weapon.GetType().Name}; Урон: {weapon.Damage}; Звук: ");
    }
}