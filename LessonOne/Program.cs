using System;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Barn build = new("Сарай", 1.78, 1.0, 0.98, "Дерево");
            build.GetParameters(build);
            build.TurningOnLight(true);
        }
    }
}
