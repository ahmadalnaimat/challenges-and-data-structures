using System;
using System.Text;
using static Queue;

public class Program
{
    public static void Main(string[] args)
    {
        StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        Console.WriteLine("Stack Content:");
        stack.Print();
        Console.WriteLine("Stack After Delete Middle");
        stack.DeleteMiddle();
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
    public int Count { get; private set; }
    public Stack()
    {
        Top = null;
    }
    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = Top;
        Top = newNode;
        Count++;
    }
    public int Pop()
    {
        if (IsEmpty())
            throw new Exception("Stack is empty");

        int data = Top.Data;
        Top = Top.Next;
        Count--;
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
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            if (Count == 1)
            {
                Pop();
                return;
            }

            int middleIndex = Count / 2;
            Stack tempStack = new Stack();

            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(Pop());
            }

            Pop();

            while (!tempStack.IsEmpty())
            {
                Push(tempStack.Pop());
            }
        }
    }
}
