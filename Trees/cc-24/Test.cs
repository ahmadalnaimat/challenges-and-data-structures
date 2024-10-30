using Xunit;

public class BinaryTreeTests
{
    [Fact]
    public void ConvertToBST()
    {
        BinaryTree bTree = new BinaryTree();
        bTree.Root = new TNode(40);
        bTree.Root.Left = new TNode(10);
        bTree.Root.Right = new TNode(50);
        bTree.Root.Left.Left = new TNode(5);
        bTree.Root.Left.Right = new TNode(30);
        bTree.Root.Right.Right = new TNode(60);
        bTree.Root.Left.Right.Left = new TNode(20);
        bTree.Root.Left.Right.Right = new TNode(80);

        bTree.ConvertToBST();

        Assert.True(IsBST(bTree.Root));
    }

    [Fact]
    public void LeftTree()
    {
        BinaryTree bTree = new BinaryTree();
        bTree.Root = new TNode(3);
        bTree.Root.Left = new TNode(2);
        bTree.Root.Left.Left = new TNode(1);

        bTree.ConvertToBST();

        Assert.True(IsBST(bTree.Root));
    }

    private bool IsBST(TNode node, int? min = null, int? max = null)
    {
        if (node == null) return true;

        if ((min.HasValue && node.Value <= min.Value) ||
            (max.HasValue && node.Value >= max.Value))
        {
            return false;
        }

        return IsBST(node.Left, min, node.Value) && IsBST(node.Right, node.Value, max);
    }
}