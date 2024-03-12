namespace SortsAndSearches.BubbleSort;

public static class Sample
{
    private static readonly BubbleSortAlgorithm BubbleSort = new BubbleSortAlgorithm(10);
    private static int[] dataSample = [6, 5, 1, 7, 2, 4, 10, 20, 3, 100];
    public static void ExecuteSample()
    {
        Console.WriteLine("Bubble Sort Sample Running...");
        BubbleSortArray();
    }

    private static void BubbleSortArray()
    {
        ArrayPrinter(dataSample);
        BubbleSort.InsertDataArray(dataSample);
        Console.WriteLine("Bubble Sorting...");
        BubbleSort.DoBubbleSort();
        ArrayPrinter(BubbleSort.GetArray());
    }

    private static void ArrayPrinter(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ,");
        }
        Console.WriteLine();
    }
}