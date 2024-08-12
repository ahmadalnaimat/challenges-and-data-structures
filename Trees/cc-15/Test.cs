using Xunit;
using System;
using System.Text;
using static Program;

public class BinaryTreeTests
{
    [Fact]
    public void PreOrderTraversal()
    {
        var bst = new BinarySearchTree(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(3);
        bst.Add(7);
        bst.Add(18);
        var bt = new BinaryTree();
        var expectedOutput = "10 5 3 7 15 18 ";

        var result = GetTraversalOutput(() => bt.PreOrder(bst.Root));

        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void InOrderTraversal()
    {
        var bst = new BinarySearchTree(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(3);
        bst.Add(7);
        bst.Add(18);
        var bt = new BinaryTree();
        var expectedOutput = "3 5 7 10 15 18 ";

        var result = GetTraversalOutput(() => bt.InOrder(bst.Root));

        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void PostOrderTraversal()
    {
        var bst = new BinarySearchTree(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(3);
        bst.Add(7);
        bst.Add(18);
        var bt = new BinaryTree();
        var expectedOutput = "3 7 5 18 15 10 ";

        var result = GetTraversalOutput(() => bt.PostOrder(bst.Root));

        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void AddNode()
    {
        var bst = new BinarySearchTree(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(3);
        bst.Add(7);

        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(15));
        Assert.True(bst.Contains(3));
        Assert.True(bst.Contains(7));
        Assert.False(bst.Contains(20));
    }

    [Fact]
    public void Contains()
    {
        var bst = new BinarySearchTree(10);
        bst.Add(5);
        bst.Add(15);

        Assert.True(bst.Contains(10));
        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(15));
        Assert.False(bst.Contains(3));
    }

    [Fact]
    public void RemoveNode()
    {
        var bst = new BinarySearchTree(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(3);
        bst.Add(7);
        bst.Remove(15);

        Assert.False(bst.Contains(15));
        Assert.True(bst.Contains(10));
        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(3));
        Assert.True(bst.Contains(7));
    }

    private string GetTraversalOutput(Action traversalAction)
    {
        var sb = new StringBuilder();
        var originalConsoleOut = Console.Out;
        using (var sw = new StringWriter(sb))
        {
            Console.SetOut(sw);
            traversalAction();
            Console.SetOut(originalConsoleOut);
        }
        return sb.ToString();
    }
}
