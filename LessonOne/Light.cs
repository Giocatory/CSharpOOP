using System;

namespace LessonOne
{
    internal sealed class Light : IAreaValue
    {
        public void TurningOnLight(bool turn)
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