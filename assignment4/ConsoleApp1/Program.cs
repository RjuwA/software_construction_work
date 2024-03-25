using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.ForEach(Console.WriteLine);
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            list.ForEach(data => max = data > max ? data : max);
            list.ForEach(data => min = data < min ? data : min);
            list.ForEach(data => sum+=data);
            Console.WriteLine($"max={max},min={min},sum={sum}");

        }
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }

        public class LinkedList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public LinkedList()
            {
                tail = head = null;
            }
            public Node<T> Head { get => head; }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if(tail==null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                    
                }
            }

            public void ForEach(Action<T> action)
            {
                Node<T> n = head;
                while (n != null)
                {
                    action(n.Data);
                    n = n.Next;
                }
            }
            
        }
    }
}
