﻿using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree(10);
        tree.Add(5);
        tree.Add(15);
        tree.Add(3);
        tree.Add(7);
        tree.Add(18);

        BinaryTree binaryTree = new BinaryTree();
        Console.Write("PreOrder: ");
        binaryTree.PreOrder(tree.Root);
        Console.Write("\nInOrder: ");
        binaryTree.InOrder(tree.Root);
        Console.Write("\nPostOrder: ");
        binaryTree.PostOrder(tree.Root);
        Console.WriteLine();

        Console.WriteLine("Contains 7: " + tree.Contains(7));
        Console.WriteLine("Contains 20: " + tree.Contains(20));

        tree.Remove(15);
        Console.WriteLine("In-order Traversal after removing 15:");
        binaryTree.InOrder(tree.Root);
        Console.WriteLine();

        binaryTree.MirrorTree(tree.Root);
        Console.WriteLine("In-order Traversal after mirroring: ");
        binaryTree.InOrder(tree.Root);

        int? secondMax = binaryTree.FindSecondMax();
        if (secondMax.HasValue)
        {
            Console.WriteLine($"\nSecond Maximum Value: {secondMax.Value}");
        }
        else
        {
            Console.WriteLine("\nTree does not have a second maximum value.");
        }

    }
    public class TNode
    {
        public int Value { get; set; }
        public TNode Right { get; set; }
        public TNode Left { get; set; }
        public TNode(int value)
        {
            Value = value;
            Right = null;
            Left = null;
        }
    }
    public class BinaryTree
    {
        public TNode Root { get; set; }

        public BinaryTree(TNode root)
        {
            Root = root;
        }

        public void PreOrder(TNode node)
        {
            if (node == null) return;

            Console.Write(node.Value + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(TNode node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }

        public void PostOrder(TNode node)
        {
            if (node == null) return;

            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value + " ");
        }

        public void MirrorTree(TNode node)
        {
            if (node == null) return;

            MirrorTree(node.Left);
            MirrorTree(node.Right);

            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        public List<int> InOrderTraversal(TNode node)
        {
            List<int> result = new List<int>();
            if (node != null)
            {
                InOrderTraversal(node.Left, result);
                result.Add(node.Value);
                InOrderTraversal(node.Right, result);
            }
            return result;
        }

        private void InOrderTraversal(TNode node, List<int> result)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, result);
            result.Add(node.Value);
            InOrderTraversal(node.Right, result);
        }

        public int? FindSecondMax()
        {
            if (Root == null || (Root.Left == null && Root.Right == null))
            {
                return null;
            }

            int? max = null;
            int? secondMax = null;

            FindMaxValue(Root, ref max);

            FindSecondMaxValue(Root, max, ref secondMax);

            return secondMax;
        }

        private void FindMaxValue(TNode node, ref int? max)
        {
            if (node == null) return;

            if (max == null || node.Value > max)
            {
                max = node.Value;
            }

            FindMaxValue(node.Left, ref max);
            FindMaxValue(node.Right, ref max);
        }
        private void FindSecondMaxValue(TNode node, int? max, ref int? secondMax)
        {
            if (node == null) return;

            if (node.Value < max && (secondMax == null || node.Value > secondMax))
            {
                secondMax = node.Value;
            }

            FindSecondMaxValue(node.Left, max, ref secondMax);
            FindSecondMaxValue(node.Right, max, ref secondMax);
        }
    }

    public class BinarySearchTree
    {
        public TNode Root { get; set; }
        public BinarySearchTree(int rootvalue)
        {
            Root = new TNode(rootvalue);
        }

        public void Add(int value)
        {
            Add(Root, value);
        }
        private void Add(TNode node, int value)
        {
            if (node.Value > value)
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else
                {
                    Add(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }
        }
        public bool Contains(int value)
        {
            return Contains(Root, value);
        }
        private bool Contains(TNode node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (value == node.Value)
            {
                return true;
            }
            else if (value < node.Value)
            {
                return Contains(node.Left, value);
            }
            else
            {
                return Contains(node.Right, value);
            }
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private TNode Remove(TNode node, int value)
        {
            if (node == null)
            {
                return node;
            }

            if (value < node.Value)
            {
                node.Left = Remove(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Remove(node.Right, value);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Value = MinValue(node.Right);

                node.Right = Remove(node.Right, node.Value);
            }

            return node;
        }
        private int MinValue(TNode node)
        {
            int minv = node.Value;
            while (node.Left != null)
            {
                minv = node.Left.Value;
                node = node.Left;
            }
            return minv;
        }
    }
}
}