using System;
using System.Text;
using static Queue;

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
        Console.WriteLine("-----------------------------------");
        StackWithReverse stackWithReverse = new StackWithReverse();
        stackWithReverse.ReverseStack(stack);
        Console.WriteLine("Reverse Stack contents:");
        stack.Print();
    }
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
    public class StackWithReverse
    {
        Queue queue = new Queue();
        public void ReverseStack(Stack stack)
        {
            while (!stack.IsEmpty())
            {
                queue.EnQueue(stack.Pop());
            }
            while (!queue.IsEmpty())
            {
                stack.Push(queue.DeQueue());
            }
        }
    }
}