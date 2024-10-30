using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new TNode(10);
        Btree.Root.Left = new TNode(20);
        Btree.Root.Right = new TNode(30);
        Btree.Root.Left.Left = new TNode(40);
        Btree.Root.Left.Right = new TNode(50);
        Btree.Root.Right.Right = new TNode(60);
        Btree.Root.Left.Right.Left = new TNode(70);
        Btree.Root.Left.Right.Right = new TNode(80);

        Console.WriteLine("Binary Tree before conversion:");
        Btree.DisplayTree(Btree.Root);

        Btree.ConvertToBST();

        Console.WriteLine("\nBinary Search Tree after conversion:");
        Btree.DisplayTree(Btree.Root);
    }

    public class TNode
    {
        public int Value;
        public TNode Left;
        public TNode Right;

        public TNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public TNode Root;

        public void ConvertToBST()
        {
            if (Root == null) return;

            List<int> values = new List<int>();
            void CollectValues(TNode node)
            {
                if (node == null) return;
                values.Add(node.Value);
                CollectValues(node.Left);
                CollectValues(node.Right);
            }
            CollectValues(Root);

            values.Sort();

            int index = 0;
            void AssignSortedValuesInOrder(TNode node)
            {
                if (node == null) return;

                AssignSortedValuesInOrder(node.Left);

                node.Value = values[index++];

                AssignSortedValuesInOrder(node.Right);
            }
            AssignSortedValuesInOrder(Root);
        }

        public void DisplayTree(TNode node, string indent = "", bool isLast = true)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (isLast)
                {
                    Console.Write("R---- ");
                    indent += "     ";
                }
                else
                {
                    Console.Write("L---- ");
                    indent += "|    ";
                }
                Console.WriteLine(node.Value);
                DisplayTree(node.Left, indent, false);
                DisplayTree(node.Right, indent, true);
            }
        }
    }
}
