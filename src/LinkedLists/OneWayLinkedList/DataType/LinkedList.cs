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
        Node? currnet = First;
        while (currnet != null)
        {
            currnet = currnet.Next;
        }

        Node newNode = new Node(data);
        currnet.Next = newNode;
        Length++;
    }
    
    public void DeleteFirst()
    {
        if (First != null) First = First.Next;
        Length--;
    }

    public void DeleteEnd()
    {
        Node? currnet = First;
        while (currnet != null)
        {
            currnet = currnet.Next;
        }
        currnet = null;
        Length--;
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