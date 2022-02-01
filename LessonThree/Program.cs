using System;

namespace LessonThree
{
    internal class Program
    {
        private static void Main()
        {
            // Два интерфейса с одинаковыми методами
            // Two interfaces with the same methods

            ClassForImplenents implenents = new();
            implenents.ShowMessage(); // "Watch message...."
            Console.WriteLine();

            if (implenents is IOneInterface oneInterface)
            {
                oneInterface.ShowMessage(); // it's two methods message :)
            }
            Console.WriteLine();

            if (implenents is ITwoInterface twoInterface)
            {
                twoInterface.ShowMessage(); // it's one methods message :)
            }
            Console.WriteLine();

            // Если в классе ClassForImplements не определена реализация метода интерфейса,
            // а в интерфейсе определено тело метода

            // if the class of the interface method is not defined in the class for implements
            // and in the interface defined body methodа

            if (implenents is Interface1 interface1) interface1.showClassName(implenents);
            Console.WriteLine();

            // Если в классе ClassForImplements определена реализация метода интерфейса,
            // а в интерфейсе не определено тело метода

            // If an interface method is implemented in class for implemenms
            // and the interface does not define the body of the method
            implenents.showClassName(implenents);
        }
    }
}