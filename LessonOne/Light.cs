using System;

namespace LessonOne
{
    internal sealed class Light
    {
        public void TrunOnOf(bool turn)
        {
            if (turn)
            {
                Console.WriteLine("Свет включен");
            }
            else
            {
                Console.WriteLine("Свет выключен");
            }
        }
    }
}