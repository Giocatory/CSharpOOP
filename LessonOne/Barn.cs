using System;

namespace LessonOne
{
    // Inheritance class and interface
    internal class Barn : Building, IAreaValue
    {
        private readonly Light light = new();
        public string Material { get; private set; }

        public Barn(string name, double height, double width, double depth, string material)
            : base(name, height, width, depth)
        {
            Material = material;
        }

        public override void GetParameters(Building building)
        {
            Console.WriteLine($"Имя постройки - {Name}");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Глубина: {Depth}");
            Console.WriteLine($"Материал изготовления: {Material}");
        }

        // delegate method and Implementing the interface method
        public void TurningOnLight(bool turn)
        {
            light.TurningOnLight(turn);
        }
    }
}