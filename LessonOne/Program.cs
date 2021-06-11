using System;

namespace LessonOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Barn build = new("Сарай", 1.78, 1.0, 0.98, "Дерево");
            build.GetParameters(build);
            build.TurningOnLight(true);

            Console.WriteLine();

            // Cast type
            // Error: newBuild will not see the TurningOnLight method, because it is not defined in the BUILDING class

            Building newBuild = new Barn("Test", 2, 2, 3, "Metal");
            if (newBuild is Barn barn)
            {
                barn.GetParameters(barn);
                barn.TurningOnLight(false);
            }
        }
    }
}