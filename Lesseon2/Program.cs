using System;

namespace LesseonTwo
{
    internal class Program
    {
        private static void Main()
        {
            Player player = new();
            Weapon[] inventory = { new BaseGun(), new Bow(), new LaserGun() };

            foreach (var guns in inventory)
            {
                player.CheckInfo(guns);
                player.Fire(guns);
                Console.WriteLine();
            }
        }
    }
}