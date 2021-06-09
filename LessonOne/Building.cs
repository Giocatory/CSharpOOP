using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    internal abstract class Building
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

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