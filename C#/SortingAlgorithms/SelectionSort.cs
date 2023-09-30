namespace SortingAlgorithms;

class SelectionSort
{
    public static int[] sort(int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            int sel = list[i];
            int selId = i;
            for (int j = i; j < list.Length; j++)
            {
                if (list[j] < sel)
                {
                    sel = list[j];
                    selId = j;
                }
            }
            list[selId] = list[i];
            list[i] = sel;
        }
        return list;
    }
}