using Xunit;

public class BinaryTreeTests
{
    [Fact]
    public void FindSecondMax()
    {
        TNode root = new TNode(10);
        root.Left = new TNode(5);
        root.Right = new TNode(20);
        root.Left.Left = new TNode(3);
        root.Left.Right = new TNode(7);
        root.Right.Left = new TNode(15);
        root.Right.Right = new TNode(25);

        Program.BinaryTree btree = new Program.BinaryTree(root);

        int? secondMax = btree.FindSecondMax();

        Assert.Equal(20, secondMax);
    }

    [Fact]
    public void OneUniqueValue()
    {
        TNode root = new TNode(10);
        root.Left = new TNode(10);
        root.Right = new TNode(10);

        Program.BinaryTree btree = new Program.BinaryTree(root);

        int? secondMax = btree.FindSecondMax();

        Assert.Null(secondMax);
    }

    [Fact]
    public void NegativeValues()
    {
        TNode root = new TNode(-10);
        root.Left = new TNode(-20);
        root.Right = new TNode(-5);
        root.Left.Left = new TNode(-30);
        root.Left.Right = new TNode(-15);

        Program.BinaryTree btree = new Program.BinaryTree(root);

        int? secondMax = btree.FindSecondMax();

        Assert.Equal(-10, secondMax);
    }
}
