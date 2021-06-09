using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    internal abstract class Building
    {
        public string Name { get; private set; }
        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Depth { get; private set; }

        public Building(string name, double height, double width, double depth)
        {
            Name = name;
            Height = height;
            Width = width;
            Depth = depth;
        }

        public abstract void GetParameters(Building building);
    }
}