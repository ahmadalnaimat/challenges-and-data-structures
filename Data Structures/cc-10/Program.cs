using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList list1 = new LinkedList();
        list1.AddLast(1);
        list1.AddLast(3);
        list1.AddLast(5);

        LinkedList list2 = new LinkedList();
        list2.AddLast(2);
        list2.AddLast(4);
        list2.AddLast(6);

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

        Console.WriteLine("Merged list:");
        mergedList.PrintList();
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

    public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
    {
        LinkedList mergedList = new LinkedList();
        Node current1 = list1.head;
        Node current2 = list2.head;

        while (current1 != null && current2 != null)
        {
            if (current1.Data <= current2.Data)
            {
                mergedList.AddLast(current1.Data);
                current1 = current1.Next;
            }
            else
            {
                mergedList.AddLast(current2.Data);
                current2 = current2.Next;
            }
        }

        while (current1 != null)
        {
            mergedList.AddLast(current1.Data);
            current1 = current1.Next;
        }

        while (current2 != null)
        {
            mergedList.AddLast(current2.Data);
            current2 = current2.Next;
        }

        return mergedList;
    }
}
