namespace LessonTwelve
{
    internal class Picture : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Draw to Form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Draw to Memory");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Draw to Printer...");
        }
    }
}