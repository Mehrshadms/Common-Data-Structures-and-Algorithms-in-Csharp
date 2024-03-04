using LinkedLists.OneWayLinkedList.DataType;

namespace LinkedLists.OneWayLinkedList.Samples;

public static class InsertExamples
{
    public static void Insertions()
    {
        LinkedList linkedList = new LinkedList();
        
        linkedList.InsertStart(5);
        linkedList.InsertStart(4);
        linkedList.InsertStart(3);
        linkedList.InsertStart(2);
        linkedList.InsertStart(1);
        linkedList.InsertStart(0);
        
        linkedList.InsertAt(3,333);
        
        linkedList.InsertEnd(999);
        
        linkedList.DisplayNodes();
        
    }
}