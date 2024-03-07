namespace Stack.StackUsingLinkedList;

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node? Next { get; set; }
}