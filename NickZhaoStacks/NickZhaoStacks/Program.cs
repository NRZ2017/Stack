using System;

namespace NickZhaoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(11);
            stack.Push(22);
            stack.Push(33);
            int y = stack.Peek();
            int x = stack.Pop();
            stack.Pop();
            stack.Push(66);
            stack.Peek();

        }
    }
}
