using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.Add(5);
        list.Add(10);
        list.Add(20);
        list.Add(30);

        Console.WriteLine("Initial list:");
        list.PrintList();

        Console.WriteLine("List after removing 10:");
        list.Remove(10);
        list.PrintList();
        Console.WriteLine("Check if 20 is in the list:");
        Console.WriteLine(list.Includes(20));

        Console.WriteLine("Check if 10 is in the list:");
        Console.WriteLine(list.Includes(10));
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

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public bool Includes(int data)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == data)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Remove(int data)
    {
        if (head == null)
        {
            return;
        }

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Data == data)
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }

    public void PrintList()
    {
        Node current = head;
        Console.Write("Head -> ");
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("Null");
    }

    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }
    public void AddFirst(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public override string ToString()
    {
        Node current = head;
        StringBuilder sb = new StringBuilder();
        sb.Append("Head -> ");
        while (current != null)
        {
            sb.Append(current.Data + " -> ");
            current = current.Next;
        }
        sb.Append("Null");
        return sb.ToString();
    }
}