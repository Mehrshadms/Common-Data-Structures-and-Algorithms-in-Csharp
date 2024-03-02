namespace CommonArrayOperations.Array;

public class ArrayDataType(int capacity)
{
   public int[] IntArray = new int[capacity];
   public int Length = 0;

   public int GetIndexOf(int key)
   {
      for (int i = 0; i < Length; i++)
      {
         if (key == IntArray[i])
            return i;
      }
      return -1;
   }
   
   public bool Exists(int[] inputArr, int key)
   {
      for (int i = 0; i < Length; i++)
      {
         if (key == inputArr[i])
            return true;
      }

      return false;
   }

   public void InsertDataArray(int[] data)
   {
      for (int i = 0; i < data.GetUpperBound(0); i++)
      {
         IntArray[i] = data[i];
         Length++;
      }
   }

   public void InsertDataAt(int data,int index = 0)
   {
      for (int i = (IntArray.Length - 2); i >= index; i--)
      {
         IntArray[i + 1] = IntArray[i];
      }
      
      if(Length < IntArray.GetUpperBound(0))
         Length++;
      
      IntArray[index] = data;
   }

   public void DeleteFromEnd()
   {
      IntArray[Length] = 0;
      Length--;
   }

   public void DeleteDataAt(int index = 0)
   {
      for (int i = (index+1); i < Length; i++)
      {
         IntArray[i - 1] = IntArray[i];
      }
      Length--;
   }

}