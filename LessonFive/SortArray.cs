namespace LessonFive
{
    internal class SortArray
    {
        private int[] array;

        public int[] SetArray(int[] newArray)
        {
            array = newArray;
            return array;
        }

        public void MySort(int l, int r)
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
                MySort(l, j);
            if (l < r)
                MySort(i, r);
        }
    }
}