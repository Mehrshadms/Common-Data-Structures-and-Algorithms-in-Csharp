namespace Queue;

public interface IQueueDataType
{
    void Enqueue(int data);
    int Dequeue();
    int Peek();
    bool IsEmpty();
    bool IsFull();
}