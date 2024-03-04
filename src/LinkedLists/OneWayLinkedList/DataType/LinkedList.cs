namespace LinkedLists.OneWayLinkedList.DataType;

public class LinkedList
{
    public Node? First { get; set; }
    public int Length { get; set; } = 0;

    public void InsertStart(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = First;
        First = newNode;
        Length++;
    }

    public void InsertEnd(int data)
    {
        Node? current = First;
        while (current.Next != null)
        {
            current = current.Next;
        }

        Node newNode = new Node(data);
        newNode.Next = null;
        current.Next = newNode;
        Length++;
    }

    public void InsertAt(int nodeIndex,int data)
    {
        if (nodeIndex >= Length)
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
            Length++;
        }
    }
    
    public void DeleteFirst()
    {
        if (First.Next != null)
        {
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
        current = null;
        Length--;
    }
    
    public void DeleteAt(int nodeIndex,int data)
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