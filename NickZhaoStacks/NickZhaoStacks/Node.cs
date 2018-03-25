using System;
using System.Collections.Generic;
using System.Text;

namespace NickZhaoStacks
{
    class Node<T> where T : IComparable
    {
        public T Data;

        public Node<T> Next;

        public Node<T> Previous;

        public Node(T data, Node<T> next, Node<T> previous)
        {
            Data = data;
            Next = next;
            Previous = previous;
        }

        public Node()
        {

        }
    }
}
