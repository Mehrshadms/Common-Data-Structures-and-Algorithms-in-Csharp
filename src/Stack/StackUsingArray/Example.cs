namespace Stack.StackUsingArray;

public static class Example
{
    public static void ExecuteSample()
    {
        Stack stack = new Stack(5);

        Console.WriteLine($"Is Stack Empty : {stack.IsEmpty()} ");
        
        stack.Push(5);
        stack.Push(4);
        stack.Push(3);
        stack.Push(2);
        stack.Push(2);

        Console.WriteLine($"Is Stack Full : {stack.IsFull()}");

        int value = stack.Peek();
        
        stack.Pop();
        stack.Push(1);
        Console.WriteLine("Listing Stack Values");
        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
    }
}