using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    sealed class Light
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
