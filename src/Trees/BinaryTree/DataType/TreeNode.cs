namespace Trees.BinaryTree.DataType;

public class TreeNode(int data)
{
    public int Data { get; set; } = data;
    public TreeNode? RightChild { get; set; } = null;
    public TreeNode? LeftChild { get; set; } = null;
}