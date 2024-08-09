using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Stack contents:");
        stack.Print();
        stack.Pop();
        stack.Pop();
        Console.WriteLine("Stack contents after pop:");
        stack.Print();
        Console.WriteLine("-----------------------------------");
        Queue queue = new Queue();
        queue.EnQueue(10);
        queue.EnQueue(20);
        queue.EnQueue(30);
        Console.WriteLine("Queue contents:");
        queue.Print();
        queue.DeQueue();
        queue.DeQueue();
        Console.WriteLine("Queue contents after DeQueue:");
        queue.Print();
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class Stack
    {
        private Node Top;
        public Stack()
        {
            Top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Top;
            Top = newNode;
        }
        public int Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty");

            int data = Top.Data;
            Top = Top.Next;
            return data;
        }
        public int Peek()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty");

            return Top.Data;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }
        public void Print()
        {
            Node current = Top;
            Console.Write("Top => ");
            while (current != null)
            {
                Console.Write(current.Data + " => ");
                current = current.Next;
            }
            Console.Write("Null");
            Console.WriteLine();
        }
    }
    public class Queue
    {
        private Node Front;
        private Node Back;
        public Queue()
        {
            Front = null;
            Back = null;
        }
        public void EnQueue(int data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                Front = Back = newNode;
            }
            else
            {
                Back.Next = newNode;
                Back = newNode;
            }

        }
        public int DeQueue()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");

            int data = Front.Data;
            Front = Front.Next;

            if (Front == null)
                Back = null;

            return data;

        }
        public int Peek()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");

            return Front.Data;
        }
        public bool IsEmpty()
        {
            return Front == null;
        }
        public void Print()
        {
            Node current = Front;
            Console.Write("Front => ");
            while (current != null)
            {
                Console.Write(current.Data + " => ");
                current = current.Next;
            }
            Console.Write("Back");
            Console.WriteLine();
        }

    }
    public class MinStack : Stack
    {
        Stack minStack = new Stack();

        public new void Push(int Data)
        {
            base.Push(Data);
            if (minStack.IsEmpty() || Data <= minStack.Peek())
            {
                minStack.Push(Data);
            }
        }
        public new int Pop()
        {
            int Value = base.Pop();
            if (Value == minStack.Peek())
            {
                minStack.Pop();
            }
            return Value;
        }
        public int GetMin()
        {
            if (minStack.IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            return minStack.Peek();
        }
    }
}
