using System;

namespace LesseonTwo
{
    class Program
    {
        static void Main()
        {
            Player player = new();
            Weapon[] inventory= {new BaseGun(), new Bow(), new LaserGun()};

            foreach (var guns in inventory)
            {
                player.CheckInfo(guns);
                player.Fire(guns);
                Console.WriteLine();
            }
        }
    }
}
