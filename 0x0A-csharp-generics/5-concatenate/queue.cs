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

    ///<summary>Method that concatenates values in queues if they are of type string or char</summary>
    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return (null);
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }

        string returnThisString = "";
        Node concatLooper = head;

        while (concatLooper != null)
        {
            if (typeof(T) == typeof(char))
                returnThisString += concatLooper.value;

            else
            {
                returnThisString += concatLooper.value;
                returnThisString += " ";
            }

            concatLooper = concatLooper.next;
        }

        return (returnThisString);
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

    ///<summary>Method that prints the queue starting from the head</summary>
    public void Print()
    {
       Node printLooper = head;

        while (printLooper != null)
        {
            Console.WriteLine(printLooper.value);
            printLooper = printLooper.next;
        }

        if (count == 0)
            Console.WriteLine("Queue is empty");
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
