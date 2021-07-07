using System;

namespace LessonFive
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 10, 98, 22, 15, 24, 78, 97, 22, 20, 1, 4, 6, 8, 7, 3, 11 };

            // my array sorted
            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            /*SortArray sra = new SortArray();
            sra.SetArray(array);
            sra.MySort(0, array.Length - 1);*/

            SortArray.SetArray(array);
            SortArray.MySort(0, array.Length - 1);

            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}