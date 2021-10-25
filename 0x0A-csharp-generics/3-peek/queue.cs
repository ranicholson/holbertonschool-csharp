using System;

///<summary>Generic Queue class to do different things</summary>
class Queue<T>
{
    int count = 0;
    Node head;
    Node tail;

    ///<summary>Count method that returns number of nodes in Queue</summary>
    public int Count()
    {
        return (count);
    }

    ///<summary>Method that removes first node in Queue and returns its value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }

        T returnThisVale = head.value;
        head = head.next;
        count--;
        return (returnThisVale);
    }

    ///<summary>Returns value of first node in the queue</summary>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }

        return (head.value);
    }

    ///<summary>Checks what type the Queue is</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>Creates a new node and adds it to the end of the queue</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }

        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    ///<summary>Public class Node inside Queue class</summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

    ///<summary>Constructor that takes a value for a new node and sets it</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }
}
