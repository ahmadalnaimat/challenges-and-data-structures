using Xunit;

public class RightViewTest
{
    [Fact]
    public void TestRightView_ExampleTree()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new TNode(2);
        Btree.Root.Left = new TNode(3);
        Btree.Root.Right = new TNode(5);
        Btree.Root.Left.Left = new TNode(4);
        Btree.Root.Right.Right = new TNode(6);
        Btree.Root.Left.Left.Right = new TNode(7);

        // Capture console output
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            Btree.PrintRightView();
            var result = sw.ToString().Trim();

            Assert.Equal("2 5 6 7", result);
        }
    }

    [Fact]
    public void TestRightView_TreeWithOnlyRightNodes()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new TNode(1);
        Btree.Root.Right = new TNode(2);
        Btree.Root.Right.Right = new TNode(3);

        // Capture console output
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            Btree.PrintRightView();
            var result = sw.ToString().Trim();

            Assert.Equal("1 2 3", result);
        }
    }
}