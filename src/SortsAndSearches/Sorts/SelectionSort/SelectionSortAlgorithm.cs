using CommonArrayOperations.Array;

namespace SortsAndSearches.Sorts.SelectionSort;

public class SelectionSortAlgorithm(int capacity) : ArrayDataType(capacity)
{
    public void SelectionSort()
    {
        for (int i = 1; i < capacity; i++)
        {
            int minValueIndex = 0;
            int minValue = int.MaxValue;
            for (int j = i; j < capacity; j++)
            {
                if (_intArray[j] < minValue)
                {
                    minValue = _intArray[j];
                    minValueIndex = j;
                }
            }

            if (_intArray[minValueIndex] < _intArray[i] && minValueIndex != 0)
            {
                (_intArray[i], _intArray[minValueIndex]) = (_intArray[minValueIndex], _intArray[i]);
            }
        }
    }
}