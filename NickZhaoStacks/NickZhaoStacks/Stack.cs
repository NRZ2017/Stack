using System;
using System.Collections.Generic;
using System.Text;

namespace NickZhaoStacks
{
    class Stack<T> where T : IComparable
    {
        bool IsEmpty = true;
        public Node<T> Top;
        public Node<T> Bottom;
        int count;
        public Stack()
        {

        }

        public void Push(T value)
        {
            if (IsEmpty)
            {
                Top = new Node<T>(value, Top, Bottom);
            }

            else
            {
                Node<T> TempBlock = new Node<T>(value, Top, Bottom);
                TempBlock.Next = Top;
                Top = TempBlock;
            }
        }

      public  T Pop()
        {
            if (Top == null)
            {
                throw new Exception("Stack was empty");
            }

            T value = Top.Data;

            Top = Top.Next;
            Top.Previous = null;

            return value;
        }

      public  T Peek()
        {
            return Top.Data;
        }

        
    }
}
