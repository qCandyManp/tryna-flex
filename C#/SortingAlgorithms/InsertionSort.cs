namespace SortingAlgorithms;

class InsertionSort
{
    public static int[] sort(int[] list)
    {
        for (int i = 0; i < list.Length - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                int curVal = list[i];
                list[i] = list[i + 1];
                list[i + 1] = curVal;
                for (int j = i; j > 0; j--)
                {
                    if (list[j] < list[j - 1])
                    {
                        curVal = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = curVal;
                    }
                }
            }
        }
        return list;
    }
}