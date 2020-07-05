using System;
using System.Collections.Generic;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static void _MinStack(){
            MinStack stack = new MinStack();
            stack.Push(115);
            stack.Push(55);
            stack.Push(35);
            stack.Push(45);
            stack.Push(25);
            stack.Push(65);

            Console.WriteLine(stack.GetMin());
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.GetMin());
        }
    }

    public class MinStack
    {
        int min = Int32.MaxValue;
        Stack<Int32> stack = new Stack<Int32>();
        public void Push(int x)
        {
            // only push the old minimum value when the current 
            // minimum value changes after pushing the new value x
            if (x <= min)
            {
                stack.Push(min);
                min = x;
            }
            stack.Push(x);
        }

        public void Pop()
        {
            // if pop operation could result in the changing of the current minimum value, 
            // pop twice and change the current minimum value to the last minimum value.
            if (stack.Pop() == min) min = stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return min;
        }
    }
}