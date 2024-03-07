namespace Stack.StackUsingArray;

public class Stack(int maxSize)
{
    private int[] StackArray { get; set; } = new int[maxSize];
    private int Top { get; set; } = -1;

    public void Push(int data)
    {                                   
        if (Top < (StackArray.Length - 1))
        {
            Top++;
            StackArray[Top] = data;
        }
        
    }

    public int Pop()
    {
        if(Top < 0)
            return -1;
        Top--;
        return StackArray[(Top + 1)];
    }

    public int Peek()
    {
        if (Top < 0)
            return -1;
        return StackArray[Top];
    }

    public bool IsEmpty()
    {
        return Top == -1;
    }

    public bool IsFull()
    {
        return Top == (StackArray.Length - 1);
    }
}