namespace SortsAndSearches.Sorts;

public static class Shared
{
    public static void ArrayPrinter(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($" {arr[i]} ,");
        }
        Console.WriteLine();
    }
}