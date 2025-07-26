using System;

public class Node<T>
{
    public T Data;
    public Node<T> Next;

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

// Stack implementation using Linked List
public class LinkedListStack<T>
{
    private Node<T> top;

    public void Push(T item) // O(1)
    {
        Node<T> newNode = new Node<T>(item);
        newNode.Next = top;
        top = newNode;
    }

    public T Pop() // O(1)
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");
        T data = top.Data;
        top = top.Next;
        return data;
    }

    public T GetTop() // O(1)
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");
        return top.Data;
    }

    public bool IsEmpty() => top == null;
}

// Queue implementation using Linked List
public class LinkedListQueue<T>
{
    private Node<T> front;
    private Node<T> rear;
    private int count;

    public void Enqueue(T item) // O(1)
    {
        Node<T> newNode = new Node<T>(item);
        if (rear != null)
            rear.Next = newNode;
        else
            front = newNode;

        rear = newNode;
        count++;
    }

    public T Dequeue() // O(1)
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");
        T data = front.Data;
        front = front.Next;
        if (front == null)
            rear = null;
        count--;
        return data;
    }

    public int Size() => count; // O(1)

    public bool IsEmpty() => front == null;
}

// Test Program (optional to show in video)
class Program
{
    static void Main()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine("Stack Top: " + stack.GetTop());
        Console.WriteLine("Stack Pop: " + stack.Pop());

        var queue = new LinkedListQueue<int>();
        queue.Enqueue(5);
        queue.Enqueue(15);
        Console.WriteLine("Queue Dequeue: " + queue.Dequeue());
        Console.WriteLine("Queue Size: " + queue.Size());
    }
}
