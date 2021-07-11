namespace LessonFive
{
    internal class SortArray
    {
        private int[] array;
        private int l;
        private int r;

        public void SetArray(int[] newArray, int l, int r)
        {
            array = newArray;
            this.l = l;
            this.r = r;

            void MySort()
            {
                int i = l;
                int j = r;
                int x = array[(l + r) / 2];
                do
                {
                    while (array[i] < x) i++;
                    while (array[j] > x) j--;
                    if (i <= j)
                    {
                        int y = array[i];
                        array[i] = array[j];
                        array[j] = y;
                        i++;
                        j--;
                    }
                } while (i < j);
                if (l < j)
                    MySort();
                if (l < r)
                    MySort();
            }
        }
    }
}