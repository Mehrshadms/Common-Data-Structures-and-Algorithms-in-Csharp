namespace CommonArrayOperations.Benchmark;

public static class Helper
{
    public static int[] GenerateSortedArrayBy(int maxNum)
    {
        int[] arr = new int[maxNum];
        for (int i = 0; i < maxNum; i++)
        {
            arr[i] = i;
        }

        return arr;
    }
}