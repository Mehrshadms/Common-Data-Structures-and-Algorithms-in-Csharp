using CommonArrayOperations.Array;

namespace CommonArrayOperations.Samples;

public class InsertExample
{
    public void InsertArray()
    {
        ArrayDataType arr = new ArrayDataType(10);
        arr.InsertDataArray([1,2,3,4,5,6,7,8,9,10]);
        Console.WriteLine($"There is {arr.Length} Element");

    }
}