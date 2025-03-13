using System;

public class GenericLinkedList<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;

    public void Add(T data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void ForEach(Action<T> action)
    {
        Node current = head;
        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        GenericLinkedList<int> list = new GenericLinkedList<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(5);
        list.Add(15);

        Console.WriteLine("链表元素：");
        list.ForEach(x => Console.WriteLine(x));

        int sum = 0;
        list.ForEach(x => sum += x);
        Console.WriteLine($"总和：{sum}");

        int max = int.MinValue;
        list.ForEach(x => { if (x > max) max = x; });
        Console.WriteLine($"最大值：{max}");

        int min = int.MaxValue;
        list.ForEach(x => { if (x < min) min = x; });
        Console.WriteLine($"最小值：{min}");
    }
}
