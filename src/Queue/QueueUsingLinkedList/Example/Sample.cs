using Queue.QueueUsingLinkedList.DataType;

namespace Queue.QueueUsingLinkedList.Example;

public static class Sample
{
    private static readonly QueueLinkedListDataType QueueDataType = new QueueLinkedListDataType();

    public static void ExecuteSample()
    {
        Console.WriteLine("Queue Using Single Linked List Sample...");
        Insertion();
        Deletion();
    }

    private static void Insertion()
    {
        Console.WriteLine("Insertion Sample...");

        Console.WriteLine($"Is Queue Empty? {QueueDataType.IsEmpty()}");

        Console.WriteLine("Adding data...");
        QueueDataType.Enqueue(1);
        QueueDataType.Enqueue(2);
        QueueDataType.Enqueue(3);
        QueueDataType.Enqueue(4);
        QueueDataType.Enqueue(5);
        QueueDataType.Enqueue(6);

        Console.WriteLine($"Is Queue Full? {QueueDataType.IsFull()}");
        Console.WriteLine($"Is Queue Empty? {QueueDataType.IsEmpty()}");
        Console.WriteLine($"There Is {QueueDataType.Length} items in Queue");
        
    }

    private static void Deletion()
    {
        Console.WriteLine("Deletion Sample...");
        
        int successPeek = QueueDataType.Peek();

        for (int i = 0; i < 6; i++)
        {
            QueueDataType.Dequeue();
        }
        
        int failedPeek = QueueDataType.Peek();
        
        Console.WriteLine($"Is Queue Full? {QueueDataType.IsFull()}");
        Console.WriteLine($"Is Queue Empty? {QueueDataType.IsEmpty()}");
        Console.WriteLine($"There Is {QueueDataType.Length} items in Queue");
    }

}