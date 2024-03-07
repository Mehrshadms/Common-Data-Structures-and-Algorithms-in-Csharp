namespace CommonArrayOperations.Array;

public class ArrayDataType(int capacity)
{
   private int[] _intArray { get; set; } = new int[capacity];
   public int Length { get; private set; } = 0;

   public int GetIndexOf(int key)
   {
      for (int i = 0; i < Length; i++)
      {
         if (key == _intArray[i])
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

   public bool IsEmpty()
   {
      return Length == 0;
   }

   public bool IsFull()
   {
      return Length == (_intArray.Length);
   }

   public void InsertDataArray(int[] data)
   {
      if(data.Length >= _intArray.Length)
         return;
      
      for (int i = 0; i < data.GetUpperBound(0); i++)
      {
         _intArray[i] = data[i];
         Length++;
      }
   }

   public void InsertEnd(int data)
   {
      if (Length >= (_intArray.Length)) return;
      
      _intArray[Length] = data;
      Length++;
   }

   public void InsertStart(int data)
   {
      if(Length >= (_intArray.Length)) return;
      
      for (int i = Length; i > 0; i--)
      {
         _intArray[i] = _intArray[i-1];
      }
      _intArray[0] = data;
      Length++;
   }

   public void InsertAt(int data,int index = 0)
   {
      for (int i = Length; i >= index; i--)
      {
         _intArray[i + 1] = _intArray[i];
      }
      _intArray[index] = data;
      Length++;
   }

   public void DeleteEnd()
   {
      _intArray[Length] = 0;
      Length--;
   }

   public void DeleteStart()
   {
      for (int i = 1; i <= Length; i++)
      {
         _intArray[i - 1] = _intArray[i];
      }
      Length--;
   }

   public void DeleteAt(int index = 0)
   {
      for (int i = (index+1); i < Length; i++)
      {
         _intArray[i - 1] = _intArray[i];
      }
      Length--;
   }

}