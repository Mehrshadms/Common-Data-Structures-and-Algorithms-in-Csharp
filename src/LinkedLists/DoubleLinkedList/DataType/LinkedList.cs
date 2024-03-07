namespace LinkedLists.DoubleLinkedList.DataType;

public class LinkedList
{
    public Node? First { get; set; }
    public int Length { get; set; } = 0;

    public void InsertStart(int data)
    {
        Node newNode = new Node(data); 
        newNode.Previous = null;
        if (First != null)
        {
            newNode.Next = First;
            First.Previous = newNode;
            First = newNode;
        }
        else
        {
            newNode.Next = null;
            First = newNode;
        }
        
        Length++;
    }
    public void InsertEnd(int data)
    {
        Node current = First;
        while (current.Next != null)
        {
            current = current.Next;
        }
        Node newNode = new Node(data);
        current.Next = newNode;
        newNode.Previous = current;
        Length++;
    }

    public void InsertAt(int nodeIndex,int data)
    {
        if (nodeIndex > Length)
        {
            InsertEnd(data);
        }
        else if(nodeIndex == 0)
        {
            InsertStart(data);
        }
        else
        {
            Node? current = First;
            for (int i = 0; i < nodeIndex; i++)
            {
                if(current.Next != null)
                    current = current.Next;
            }
            Node newNode = new Node(data);
            newNode.Next = current.Next;
            current.Next = newNode;
            newNode.Previous = current;
            if(newNode.Next != null)
                newNode.Next.Previous = newNode;
            Length++;
        }
    }

    public void DeleteFirst()
    {
        if(First.Next != null)
        {
            First.Next.Previous = null;
            First = First.Next;
            Length--;
        }
    }

    public void DeleteEnd()
    {
        Node? current = First;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Previous.Next = null;
    }

    public void DeleteAt(int nodeIndex)
    {
        if (nodeIndex >= Length)
        {
            DeleteEnd();
        }
        else if(nodeIndex == 0)
        {
            DeleteFirst();
        }
        else
        {
            Node? current = First;
            for (int i = 0; i < nodeIndex; i++)
            {
                if(current.Next != null)
                    current = current.Next;
            }
            current.Next = current.Next.Next;
            current.Next.Next.Previous = current.Next.Previous;
            Length--;
        }
    }
    
    public void DisplayNodes()
    {
        Node? current = First;
        while (current != null)
        {
            current.DisplayData();
            current = current.Next;
        }
    }
}