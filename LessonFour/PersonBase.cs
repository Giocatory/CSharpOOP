using System;

namespace LessonFour
{
    public partial class Person
    {
        public void Eat()
        {
            Console.WriteLine("I'm eating...");
        }

        partial void Read();

        public void DoSomething()
        {
            Read();
        }
    }
}