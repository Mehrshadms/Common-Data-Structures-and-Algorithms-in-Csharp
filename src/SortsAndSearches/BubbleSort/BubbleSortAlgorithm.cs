using CommonArrayOperations.Array;

namespace SortsAndSearches.BubbleSort;

public class BubbleSortAlgorithm(int capacity) : ArrayDataType(capacity)
{
    public void DoBubbleSort()
    {
        for (int i = 0; i < _intArray.Length; i++)
        {
            bool isTriggered = false;
            for (int j = 1; j < _intArray.Length; j++)
            {
                int left = _intArray[j - 1];
                int right = _intArray[j];
                if(left > right)
                {
                    _intArray[j] = left;
                    _intArray[j - 1] = right;
                    isTriggered = true;
                }
            }
            if(!isTriggered)
                return;
        }
    }
}