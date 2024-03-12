using Trees.Shared;

namespace Trees.BinaryTree.DataType;

public class BinaryTreeDataType
{
    private TreeNode? Root { get; set; }

    public void RecursionInsert(int data)
    {
        Root = RecursionInsertItem(Root, data);
    }
    private TreeNode? RecursionInsertItem(TreeNode? node, int data)
    {
        if (node is null)
        {
            node = new TreeNode(data);
            return node;
        }

        if (data > node.Data)
        {
            node.RightChild = RecursionInsertItem(node.RightChild, data);
        }
        else if(data < node.Data)
        {
            node.LeftChild = RecursionInsertItem(node.LeftChild, data);
        }

        return node;
    }
    
    public void InsertWithoutRecursion( int data)
    {
        if (Root is null)
        {
            Root = new TreeNode(data);
            return;
        }

        TreeNode node = Root;
        while (node != null)
        {
            if (data > node.Data)
            {
                if (node.RightChild is null)
                {
                    node.RightChild = new TreeNode(data);
                    return;
                }
                else
                {
                    node  = node.RightChild;
                }
            }
            else if(data < node.Data)
            {
                if (node.LeftChild is null)
                {
                    node.LeftChild = new TreeNode(data);
                    return;
                }
                else
                {
                    node = node.LeftChild;
                }
            }
        }
    }

    public bool RecursionExists(int data)
    {
        TreeNode node = RecursionExistsItem(Root,data);
        return node != null;
    }
    
    private TreeNode? RecursionExistsItem(TreeNode node,int data)
    {
        if (node is null || node.Data == data)
            return node;
        
        if (data > node.Data)
        {
            return RecursionExistsItem(node.RightChild, data);
        }
        else if(data < node.Data)
        {
            return RecursionExistsItem(node.LeftChild, data);
        }

        return null;
    }

    public bool IterationExists(int data)
    {
        TreeNode node = Root;
        while (node != null)
        {
            if (node.Data == data)
            {
                return true;
            }
            else if(data > node.Data)
            {
                node = node.RightChild;
            }
            else if(data < node.Data)
            {
                node = node.LeftChild;
            }
        }
        return false;
    }
}