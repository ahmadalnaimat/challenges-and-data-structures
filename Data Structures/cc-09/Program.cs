using System;

public class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
public class LinkedList
{
    public Node Head;
    public LinkedList()
    {
        Head = null;
    }
    public void Display()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("Null");
    }
    public void RemoveDuplicate()
    {
        Node current = Head;
        while (current != null)
        {
            Node index = current;
            while (index.Next != null)
            {
                if (current.Data == index.Next.Data)
                {
                    index.Next = index.Next.Next;
                }
                else
                {
                    index = index.Next;
                }
            }
            current = current.Next;
        }
    }
}
public class Program
{
    public static void Main()
    {
        LinkedList list = new LinkedList();
        list.Head = new Node(5);
        list.Head.Next = new Node(20);
        list.Head.Next.Next = new Node(20);
        list.Head.Next.Next.Next = new Node(10);
        list.Head.Next.Next.Next.Next = new Node(5);
        list.Head.Next.Next.Next.Next.Next = new Node(10);
        Console.WriteLine("Before removing duplicates:");
        list.Display();
        list.RemoveDuplicate();
        Console.WriteLine("After removing duplicates:");
        list.Display();
    }
}