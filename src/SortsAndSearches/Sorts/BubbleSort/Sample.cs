namespace SortsAndSearches.Sorts.BubbleSort;

public static class Sample
{
    private static readonly BubbleSortAlgorithm BubbleSort = new BubbleSortAlgorithm(10);
    public static void ExecuteSample()
    {
        Console.WriteLine("Bubble Sort Sample Running...");
        BubbleSortArray();
        Console.WriteLine("Done.");
    }

    private static void BubbleSortArray()
    {
        Shared.ArrayPrinter(DataSamples.DataSample);
        BubbleSort.InsertDataArray(DataSamples.DataSample);
        Console.WriteLine("Bubble Sorting...");
        BubbleSort.DoBubbleSort();
        Shared.ArrayPrinter(BubbleSort.GetArray());
    }

}