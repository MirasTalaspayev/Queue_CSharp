using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Queue_CSharp
{
    class Node
    {
        public int val;
        public Node next;
        public Node() { }
        public Node(int value)
        {
            val = value;
            next = null;
        }
    }
    class Queue
    {
        Node front;
        Node back;
        private int queue_size { get; set; }

        public Queue()
        {
            front = null;
            back = null;
            queue_size = 0;
        }
        public Queue(Queue que)
        {
            Node temp = que.front;
            while (temp != null)
            {
                Push(temp.val);
                temp = temp.next;
            }
        }
        public Queue(List<int> list)
        {
            foreach (int i in list)
            {
                Push(i);
            }
        }
        public void Push(int val)
        {
            Node temp = new Node(val);
            if (queue_size == 0)
            {
                front = temp;
                back = temp;
            }
            else
            {
                back.next = temp;
                back = temp;
            }
            queue_size++;
        }
        public void Pop()
        {
            if (queue_size == 0)
                throw new ArgumentOutOfRangeException("Pop().", "Queue is Empty.");

            else if (queue_size == 1)
            {
                front = null;
                back = null;
                return;
            }
            Node temp = front;
            front = front.next;
        }
        public void Clear()
        {
            front = null;
            back = null;
        }
        public int Peek()
        {
            if (queue_size == 0)
                throw new ArgumentOutOfRangeException("Pop().", "Queue is Empty.");
            return front.val;
        }
        public int Size()
        {
            return queue_size;
        }
        public bool Empty()
        {
            return queue_size == 0;
        }
        public void Print()
        {
            Console.WriteLine("[");
            Node temp = front;
            while (temp != back)
            {
                Console.Write(temp.val + ", ");
                temp = temp.next;
            }
            Console.Write(temp.val + "]");
        }
    }
}
