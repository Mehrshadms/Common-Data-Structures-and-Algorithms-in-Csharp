using CommonArrayOperations.Array;

namespace CommonArrayOperations.Examples;

public static class CommonArrayOperationSample
{ 
    private static readonly ArrayDataType Arr = new ArrayDataType(10);
    private static void Insertion()
    {
        Console.WriteLine("Insertion Sample ...");
        Arr.InsertDataArray([1,2,3,4,6,7,8]);
        
        Arr.InsertAt(5,4);
        Arr.InsertStart(0);
        Arr.InsertEnd(9);
        
        Console.WriteLine($"Is Array Empty? {Arr.IsEmpty()}");
        
        Arr.InsertEnd(10);
        
        Console.WriteLine($"Is Array Full? {Arr.IsFull()}");
        Console.WriteLine($"There is {Arr.Length} Element");
    }

    private static void SortAndSearch()
    {
        Arr.Exists(9);
    }

    private static void Deletion()
    {
        Console.WriteLine("Deletion Sample ...");
        
        Arr.DeleteAt(5);
        
        Arr.DeleteEnd();
        Arr.DeleteEnd();
        
        Arr.DeleteStart();
        Arr.DeleteStart();
        Arr.DeleteStart();
        
        Console.WriteLine($"Is Array Full? {Arr.IsFull()}");
        Console.WriteLine($"There is {Arr.Length} Element");
    }

    public static void ExecuteSample()
    {
        Insertion();
        Console.WriteLine(new string('=',10));
        Deletion();
    }
}