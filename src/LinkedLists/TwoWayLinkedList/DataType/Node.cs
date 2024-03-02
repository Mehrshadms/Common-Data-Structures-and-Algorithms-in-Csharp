namespace LinkedLists.TwoWayLinkedList.DataType;

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node? Previous { get; set; }
    public Node? Next { get; set; }

    public void DisplayData()
    {
        Console.WriteLine(data);
    }
}