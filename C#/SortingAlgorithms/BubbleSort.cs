namespace SortingAlgorithms;

class BubbleSort
{
    public static int[] sort(int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = 0; j < list.Length - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int curVal = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = curVal;
                }
            }
        }
        return list;
    }
}