using Trees.BinaryTree.DataType;

namespace Trees.BinaryTree.Example;

public static class Sample
{
    private static readonly BinaryTreeDataType RecursionType = new BinaryTreeDataType();
    private static readonly BinaryTreeDataType IterationType = new BinaryTreeDataType();
    private static void InsertUsingRecursion()
    {
        Console.WriteLine("Recursion Starting...");

        RecursionType.RecursionInsert(25);
        RecursionType.RecursionInsert(20);
        RecursionType.RecursionInsert(10);
        RecursionType.RecursionInsert(22);
        RecursionType.RecursionInsert(36);
        RecursionType.RecursionInsert(40);
        RecursionType.RecursionInsert(30);
        RecursionType.RecursionInsert(48);

        Console.WriteLine("Recursion Done.");
    }
    private static void InsertUsingIteration()
    {
        Console.WriteLine("Iteration Starting...");

        IterationType.InsertWithoutRecursion(25);
        IterationType.InsertWithoutRecursion(20);
        IterationType.InsertWithoutRecursion(10);
        IterationType.InsertWithoutRecursion(22);
        IterationType.InsertWithoutRecursion(36);
        IterationType.InsertWithoutRecursion(40);
        IterationType.InsertWithoutRecursion(30);
        IterationType.InsertWithoutRecursion(48);

        Console.WriteLine("Iteration Done.");
    }

    public static void ExecuteSample()
    {
        InsertUsingIteration();
        InsertUsingRecursion();
    }
}