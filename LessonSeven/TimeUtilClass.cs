using static System.Console;
using static System.DateTime;
// Importing Static Members

namespace LessonSeven
{
    internal static class TimeUtilClass
    {
        // A static class can only contain static fields and methods
        public static void PrintTime() => WriteLine(Now.ToShortTimeString());

        public static void PrintDate() => WriteLine(Today.ToShortDateString());
    }
}
