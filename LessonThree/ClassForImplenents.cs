using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    class ClassForImplenents : ITwoInterface, IOneInterface, Interface1
    {
        public void ShowMessage()
        {
            Console.WriteLine("Watch message....");
        }

        void ITwoInterface.ShowMessage()
        {
            Console.WriteLine("it's two methods message :)");
        }
        void IOneInterface.ShowMessage()
        {
            Console.WriteLine("it's one methods message :)");
        }


        // если в интерфейсе есть метод с пустым телом или вообще с телом,
        // то его реализация не обязательна
        // т.е. Код ниже можно и не писать, ошибки не будет

        // if the interface has a method with an empty body or in general with the body,
        // then its implementation is not obligatory
        // i.e. The code below can not write, there will be no errors

        public void showClassName(object objectName)
        {
            Console.WriteLine(objectName.GetType().Name);
        }
    }
}
