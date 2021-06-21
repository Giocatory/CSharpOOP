using System;

namespace LessonFour
{
    public partial class Person
    {
        public void Eat()
        {
            Console.WriteLine("I'm eating...");
        }

        public partial void Read();

        public void DoSomething()
        {
            Console.Write("everyday ");
            Read();
        }
    }
}