namespace LinkedLists.OneWayLinkedList.DataType;

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node? Next { get; set; }

    public void DisplayData()
    {
        Console.WriteLine(Data);
    }
}