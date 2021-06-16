using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    interface Interface1
    {
        void showClassName(object objectName) { Console.WriteLine(objectName.GetType().Name); }
    }
}
