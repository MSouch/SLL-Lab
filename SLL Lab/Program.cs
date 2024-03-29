using System;
public class Node
{
    // Value stored in the node
    public string Value { get; set; }
    // Reference to the next node in the list
    public Node Next { get; set; }

    // Constructor to initialize a new node with a given value
    public Node(string value)
    {
        Value = value;
        Next = null;
    }
}

// LinkedList class represents a collection of nodes forming a linked list
public class LinkedList
{
    // Property to store the number of nodes in the list
    public int Count { get; private set; }
    // Property to store the reference to the first node in the list (head)
    public Node Head { get; private set; }

    // Constructor to initialize an empty linked list
    public LinkedList()
    {
        Count = 0;
        Head = null;
    }

    // Method to add a new node with the given value to the beginning of the list
    public void AddFirst(string value)
    {
        Node newNode = new Node(value);
        newNode.Next = Head;
        Head = newNode;
        Count++;
    }

    // Method to add a new node with the given value to the end of the list
    public void AddLast(string value)
    {
        Node newNode = new Node(value);

        // If the list is empty, set the new node as the head
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            // Traverse to the last node and add the new node after it
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        Count++;
    }

    // Method to remove the first node in the list
    public void RemoveFirst()
    {
        if (Head != null)
        {
            Head = Head.Next;
            Count--;
        }
    }

    // Method to remove the last node in the list
    public void RemoveLast()
    {
        if (Head != null)
        {
            // If there is only one node, set head to null
            if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                // Traverse to the second last node and remove its reference to the last node
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            Count--;
        }
    }

    // Method to retrieve the value of the node at the given index
    public string GetValue(int index)
    {
        // Check if the index is within the valid range
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        // Traverse the list to the desired index and return the value
        Node current = Head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }
        return current.Value;
    }
}

// Main program class for testing the LinkedList class
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the LinkedList
        LinkedList list = new LinkedList();

        // Add elements to the list
        list.AddFirst("First");
        list.AddLast("Second");
        list.AddLast("Third");

        // Display values in the list
        Console.WriteLine("Values in the list:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.GetValue(i));
        }

        // Remove the first and last elements from the list
        list.RemoveFirst();
        list.RemoveLast();

        // Display values in the list after removal
        Console.WriteLine("\nValues in the list after removing first and last:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.GetValue(i));
        }
    }
}
