using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        TNode Root = new TNode(9);
        Root.Left = new TNode(8);
        Root.Right = new TNode(12);
        Root.Left.Left = new TNode(3);
        Root.Left.Right = new TNode(7);
        Root.Right.Left = new TNode(17);
        Root.Right.Right = new TNode(23);
        Root.Left.Left.Right = new TNode(4);
        BinaryTree Btree = new BinaryTree(Root);

        int leafSum = Btree.SumOfLeafNodes();
        Console.WriteLine($"Sum of all leaf nodes: {leafSum}");

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
        public int SumOfLeafNodes()
        {
            return LeafSum(Root);
        }

        private int LeafSum(TNode node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }

            return LeafSum(node.Left) + LeafSum(node.Right);
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