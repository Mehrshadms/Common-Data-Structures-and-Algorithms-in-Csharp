namespace SortsAndSearches.Sorts.SelectionSort;

public static class Sample
{
    private static readonly SelectionSortAlgorithm SelectionSort = new SelectionSortAlgorithm(10);

    public static void ExecuteSample()
    {
        Console.WriteLine("Selection Sort Sample Running...");
        SelectionSortArray();
        Console.WriteLine("Done.");
    }

    private static void SelectionSortArray()
    {
        Shared.ArrayPrinter(DataSamples.DataSample);
        SelectionSort.InsertDataArray(DataSamples.DataSample);
        Console.WriteLine("Selection Sorting...");
        SelectionSort.SelectionSort();
        Shared.ArrayPrinter(SelectionSort.GetArray());
    }
}