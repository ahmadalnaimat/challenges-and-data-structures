using Xunit;

public class MaxLevelNodesTest
{
    [Fact]
    public void MaxLevelNodes()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new TNode(1);
        Btree.Root.Left = new TNode(2);
        Btree.Root.Right = new TNode(3);
        Btree.Root.Left.Left = new TNode(4);
        Btree.Root.Left.Right = new TNode(5);
        Btree.Root.Right.Right = new TNode(6);
        Btree.Root.Left.Left.Left = new TNode(7);

        int maxLevel = Btree.FindMaxLevelNodes();
        Assert.Equal(2, maxLevel); // Expected output: 2
    }

    [Fact]
    public void MultipleSameMaxLevels()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new TNode(1);
        Btree.Root.Left = new TNode(2);
        Btree.Root.Right = new TNode(3);
        Btree.Root.Left.Left = new TNode(4);
        Btree.Root.Right.Left = new TNode(5);
        Btree.Root.Right.Right = new TNode(6);
        Btree.Root.Left.Left.Left = new TNode(7);

        int maxLevel = Btree.FindMaxLevelNodes();
        Assert.Equal(2, maxLevel); // Expected output: 2
    }
}
