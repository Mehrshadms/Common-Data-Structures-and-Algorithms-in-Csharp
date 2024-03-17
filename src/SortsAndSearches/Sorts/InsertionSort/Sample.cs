namespace SortsAndSearches.Sorts.InsertionSort;

public static class Sample
{
    private static readonly InsertionSortAlgorithm InsertionSort = new InsertionSortAlgorithm(10);

    public static void ExecuteSample()
    {
        Console.WriteLine("Insertion Sort Sample Running...");
        SelectionSortArray();
        Console.WriteLine("Done.");
    }

    private static void SelectionSortArray()
    {
        Shared.ArrayPrinter(DataSamples.DataSample);
        InsertionSort.InsertDataArray(DataSamples.DataSample);
        Console.WriteLine("Insertion Sorting...");
        InsertionSort.InsertionSort();
        Shared.ArrayPrinter(InsertionSort.GetArray());
    }
}