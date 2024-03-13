using CommonArrayOperations.Array;

namespace SortsAndSearches.Searches.BinarySearch;

public class BinarySearch(int capacity) : ArrayDataType(capacity)
{
       
    public int GetIndexOfWithBinarySearch(int key)
    {
        int min = 0;
        int max = (_intArray.Length-1);
        // //EdgeCases?
        // if (_intArray[min] == key)
        //    return true;
        // if (_intArray[max] == key)
        //    return true;
      
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (_intArray[mid] == key)
                return mid;
            if (_intArray[mid] > key)
            {
                max = mid;
            }
            else if(_intArray[mid] < key)
            {
                min = (mid + 1);
            }
        }

        return -1;
    }
    
    public bool ExistsWithBinarySearch( int key)
    {
        int min = 0;
        int max = (_intArray.Length-1);
        // //EdgeCases?
        // if (_intArray[min] == key)
        //    return true;
        // if (_intArray[max] == key)
        //    return true;
      
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (_intArray[mid] == key)
                return true;
            if (_intArray[mid] > key)
            {
                max = mid;
            }
            else if(_intArray[mid] < key)
            {
                min = (mid + 1);
            }
        }

        return false;
    }
}