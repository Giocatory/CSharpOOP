namespace LessonSeven
{
    internal static class TimeUtilClass
    {
        // A static class can only contain static fields and methods
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }
}
