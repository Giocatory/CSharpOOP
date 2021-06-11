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


            Console.WriteLine();

            // Cast type
            Building newBuild = new Barn("Test", 2, 2, 3, "Metal");
            if (newBuild is Barn barn)
            {
                barn = (Barn)newBuild;
                barn.GetParameters(barn);
                barn.TurningOnLight(false);
            }
        }
    }
}