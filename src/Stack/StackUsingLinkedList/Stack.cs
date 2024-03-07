namespace Stack.StackUsingLinkedList;

public class Stack
{
    public Node? Top { get; private set; }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = Top;
        Top = newNode;
    }

    public int Pop()
    {
        if (Top == null)
            return -1;

        int result = Top.Data;
        Top = Top.Next;
        return result;
    }

    public int Peek()
    {
        if (Top == null)
            return -1;
        
        return Top.Data;
    }

    public bool IsEmpty()
    {
        return Top == null;
    }

    public bool IsFull()
    {
        // one of the benefits of implementing Stack using LinkedList
        // is easier implementation of Growing Stack  
        return false;
    }
}