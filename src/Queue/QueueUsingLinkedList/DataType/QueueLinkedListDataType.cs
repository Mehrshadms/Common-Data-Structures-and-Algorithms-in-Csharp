namespace Queue.QueueUsingLinkedList.DataType;

public class QueueLinkedListDataType : IQueueDataType
{
    private Qnode? Front { get; set; } = null;
    private Qnode? Rear { get; set; } = null;
    public int Length { get; set; }


    public void Enqueue(int data)
    {
        Qnode node = new Qnode(data);
        if (Rear == null)
        {
            Front = Rear = node;
        }
        else
        {
            Rear.Next = node;
            Rear = node;
        }

        Length++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
            return -1;
        
        int result = Front.Data;
        Front = Front.Next;
        
        if (IsEmpty())
            Rear = null;

        Length--;
        return result;
    }

    public int Peek()
    {
        if (IsEmpty()) 
            return -1;
        
        return Front.Data;
    }

    public bool IsEmpty()
    {
        return Front == null;
    }

    public bool IsFull()
    {
        return false;
    }
}