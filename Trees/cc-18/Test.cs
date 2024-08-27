using System;
using Xunit;

public class BinaryTreeTests
{
    [Fact]
    public void ReturnSum()
    {
        // Arrange
        TNode root = new TNode(9);
        root.Left = new TNode(8);
        root.Right = new TNode(12);
        root.Left.Left = new TNode(3);
        root.Left.Right = new TNode(7);
        root.Right.Left = new TNode(17);
        root.Right.Right = new TNode(23);
        root.Left.Left.Right = new TNode(4);
        BinaryTree binaryTree = new BinaryTree(root);

        // Act
        int sum = binaryTree.SumOfLeafNodes();

        // Assert
        Assert.Equal(51, sum); // Leaf nodes: 4 + 7 + 17 + 23 = 51
    }

    [Fact]
    public void NegativeLeafValuesSum()
    {
        // Arrange
        TNode root = new TNode(5);
        root.Left = new TNode(3);
        root.Right = new TNode(8);
        root.Left.Left = new TNode(-4);
        root.Left.Right = new TNode(-7);
        root.Right.Left = new TNode(6);
        root.Right.Right = new TNode(-10);
        BinaryTree binaryTree = new BinaryTree(root);

        // Act
        int sum = binaryTree.SumOfLeafNodes();

        // Assert
        Assert.Equal(-15, sum); // Leaf nodes: -4 + (-7) + 6 + (-10) = -15
    }
}
