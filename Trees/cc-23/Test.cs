using Xunit;

public class MinimumDepthTests
{
    [Fact]
    public void TestEmptyTree()
    {
        BinaryTree btree = new BinaryTree();
        Assert.Equal(0, btree.FindMinimumDepth());
    }

    [Fact]
    public void TestMultipleNodesWithVaryingDepths()
    {
        BinaryTree btree = new BinaryTree();
        btree.Root = new TNode(1);
        btree.Root.Left = new TNode(2);
        btree.Root.Right = new TNode(3);
        btree.Root.Left.Left = new TNode(4);
        btree.Root.Left.Right = new TNode(5);

        Assert.Equal(2, btree.FindMinimumDepth());
    }
}
