namespace Queue.QueueUsingLinkedList.DataType;

public class Qnode(int data)
{
    public int Data { get; set; } = data;
    public Qnode? Next { get; set; } = null;
}