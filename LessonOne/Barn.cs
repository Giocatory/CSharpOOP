using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    class Barn : Building
    {
        readonly Light light = new();

        public Barn(string name, double height, double width, double depth) : base(name, height, width, depth)
        {
        }

        public override void GetParameters(Building building)
        {
            Console.WriteLine($"Имя постройки - {Name}");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Глубина: {Depth}");
        }

        public void TurningOnLight(bool turn)
        {
            light.TrunOnOf(turn);
        }
    }
}
