using CommonArrayOperations.Array;

namespace SortsAndSearches.Sorts.InsertionSort;

public class InsertionSortAlgorithm(int capacity) : ArrayDataType(capacity)
{
    public void InsertionSort()
    {
        for (int i = 1; i < capacity; i++)
        {
            int j = i;
            while (_intArray[j] < _intArray[j-1])
            {
                (_intArray[j], _intArray[j - 1]) = (_intArray[j - 1], _intArray[j]);
                if (j==1)
                    break;
                j--;
            }
        }
    }
}