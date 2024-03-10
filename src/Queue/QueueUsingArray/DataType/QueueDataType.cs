namespace Queue.QueueUsingArray.DataType;

public class QueueDataType(int maxSize) : IQueueDataType
{
    private int[] Arr { get; set; } = new int[maxSize];
    private int Front { get; set; } = 0;
    private int Rear { get; set; } = -1;
    public int Length { get; set; } = 0;

    public void Enqueue(int data)
    {
        if(Rear >= (Arr.Length-1)) 
            return;

        Rear++;
        Arr[Rear] = data;
        Length++;
    }

    public int Dequeue()
    {
        if (IsEmpty()) 
            return -1;
        
        int result = Arr[Front];
        Front++;
        Length--;
        if (Front == Arr.Length)
        {
            Front = 0;
            Rear = -1;
            Length = 0;
        }
        return result;
    }

    public int Peek()
    {
        if (IsEmpty())
            return -1;
        
        return Arr[Front];
    }

    public bool IsEmpty()
    {
        return Front == (Rear + 1);
    }

    public bool IsFull()
    {
        return Length == Arr.Length;
    }
}