using Xunit;

public class BinaryTreeTests
{
    [Fact]
    public void ReturnsCorrectValues()
    {
        TNode Root = new TNode(5);
        Root.Left = new TNode(13);
        Root.Right = new TNode(7);
        Root.Left.Left = new TNode(3);
        Root.Left.Right = new TNode(7);
        Root.Right.Left = new TNode(12);
        Root.Right.Right = new TNode(20);
        Root.Left.Left.Left = new TNode(1);
        Root.Left.Left.Right = new TNode(4);
        Root.Right.Left.Right = new TNode(11);
        BinaryTree Btree = new BinaryTree(Root);

        List<int> largestValues = Btree.LargestValueEachLevel();

        Assert.Equal(new List<int> { 5, 13, 20, 11 }, largestValues);
    }

    [Fact]
    public void ReturnsEmptyList()
    {
        BinaryTree Btree = new BinaryTree();

        List<int> largestValues = Btree.LargestValueEachLevel();

        Assert.Empty(largestValues);
    }

    [Fact]
    public void ReturnsSingleValue()
    {
        TNode Root = new TNode(42);
        BinaryTree Btree = new BinaryTree(Root);

        List<int> largestValues = Btree.LargestValueEachLevel();

        Assert.Equal(new List<int> { 42 }, largestValues);
    }
}
