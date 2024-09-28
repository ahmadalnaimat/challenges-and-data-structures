using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new TNode(2);
        Btree.Root.Left = new TNode(3);
        Btree.Root.Right = new TNode(5);
        Btree.Root.Left.Left = new TNode(4);
        Btree.Root.Right.Right = new TNode(6);
        Btree.Root.Left.Left.Right = new TNode(7);

        Console.Write("Right view of the binary tree: ");
        Btree.PrintRightView();  // Expected Output: 2 5 6 7
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

        public void PrintRightView()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelCount = queue.Count;  
                TNode rightmostNode = null;    

                for (int i = 0; i < levelCount; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    rightmostNode = currentNode; 
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
                if (rightmostNode != null)
                {
                    Console.Write(rightmostNode.Value + " ");
                }
            }
            Console.WriteLine(); 
        }
    }
}
