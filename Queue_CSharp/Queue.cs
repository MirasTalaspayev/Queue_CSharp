using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Queue_CSharp
{
    class Node<T>
    {
        public T val;
        public Node<T> next;
        public Node() { }
        public Node(T value)
        {
            val = value;
            next = null;
        }
    }
    class Queue<T> : IEnumerable, IComparable
    {
        private Node<T> front { get; set; }
        private Node<T> back { get; set; }
        private int queue_size { get; set; }

        public Queue()
        {
            front = null;
            back = null;
            queue_size = 0;
        }
        public Queue(Queue<T> que)
        {
            Node<T> temp = que.front;
            while (temp != null)
            {
                Push(temp.val);
                temp = temp.next;
            }
        }
        public Queue(List<T> list)
        {
            foreach (T i in list)
            {
                Push(i);
            }
        }
        public Queue(params T[] array)
        {
            foreach (T x in array)
                Push(x);
        }
        public void Push(T val)
        {
            Node<T> temp = new Node<T>(val);
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
            Node<T> temp = front;
            front = front.next;
        }
        public void Clear()
        {
            front = null;
            back = null;
        }
        public T Peek()
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
            Console.Write("[");
            Node<T> temp = front;
            while (temp != back)
            {
                Console.Write(temp.val + ", ");
                temp = temp.next;
            }
            Console.Write(temp.val + "]");
        }
        public override string ToString()
        {
            string output = "[";
            Node<T> temp = front;
            while (temp != back)
            {
                output += String.Format(temp.val.ToString() + ", ");
                temp = temp.next;
            }
            output += String.Format(back.val + "]");
            return output;
        }
        public IEnumerator GetEnumerator()
        {
            Node<T> temp = front;
            while(temp != null)
            {
                yield return temp.val;
                temp = temp.next;
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
