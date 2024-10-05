using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
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
        Console.WriteLine($"The level with the maximum number of nodes is: {maxLevel}");
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

        public BinaryTree()
        {
            Root = null;
        }
        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);
            int maxNodes = 0;
            int levelWithMaxNodes = 0;
            int level = 0;

            while (queue.Count > 0)
            {
                int nodeCount = queue.Count;
                if (nodeCount > maxNodes)
                {
                    maxNodes = nodeCount;
                    levelWithMaxNodes = level;
                }
                for (int i = 0; i < nodeCount; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
                level++;
            }
            return levelWithMaxNodes;
        }
    }
}