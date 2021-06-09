using System;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Barn build = new Barn("Сарай", 1.78, 1.0, 0.98);
            build.GetParameters(build);
            build.TurningOnLight(true);
        }
    }
}
