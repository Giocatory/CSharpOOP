using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    class ClassForImplenents : ITwoInterface, IOneInterface
    {
        public void ShowMessage()
        {
            Console.WriteLine("Watch message....");
        }
    }
}
