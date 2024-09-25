using cc_05;
using System;
using System.Text;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);

        Console.WriteLine("Original list:");
        list.Display();

        list.RotateLeft(2);

        Console.WriteLine("After rotating by 2 positions:");
        list.Display();

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
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RotateLeft(int k)
        {
            if (Head == null || k == 0)
                return;

            Node current = Head;
            int length = 1;
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }

            current.Next = Head;

            k = k % length;
            int stepsToNewHead = length - k;

            Node newTail = Head;
            for (int i = 1; i < stepsToNewHead; i++)
            {
                newTail = newTail.Next;
            }

            Head = newTail.Next;
            newTail.Next = null;
        }

        public void Display()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}