namespace algoexpert
{
// Min Max Stack Construction

// Write a Min Max Stack class. The class should support pushing and popping values on and off the stack, peeking 
// at values at the top of the stack, and getting both the minimum and the maximum values in the stack.All class 
// methods, when considered independently, should run in constant time and with constant space.

// Sample input:
// -> push(5)
// -> getMin()
// -> getMax()
// -> peek()
// -> push(7)
// -> getMin()
// -> getMax()
// -> peek()
// -> push(2)
// -> getMin()
// -> getMax()
// -> peek()
// -> pop()
// -> pop()
// -> getMin()
// -> getMax()
// -> peek()
// Sample output:
// -> (push 5)
// -> 5 (min)
// -> 5 (max)
// -> 5 (peek)
// -> (push 7)
// -> 5 (min)
// -> 7 (max)
// -> 7 (peek)
// -> (push 2)
// -> 2 (min)
// -> 7 (max)
// -> 2 (peek)
// -> 2 (pop)
// -> 7 (pop)
// -> 5 (min)
// -> 5 (max)
// -> 5 (peek)

using System;
using System.Collections.Generic;

public partial class Program
    {
        public class MinMaxStack
        {
            List<Dictionary<string, int>> minMaxStack = new List<Dictionary<string, int>>();
            List<int> stack = new List<int>();

            // O(1) time | O(1) space
            public int Peek()
            {
                return stack[stack.Count - 1];
            }

            // O(1) time | O(1) space
            public int Pop()
            {
                minMaxStack.RemoveAt(minMaxStack.Count - 1);
                var val = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return val;
            }

            // O(1) time | O(1) space
            public void Push(int number)
            {
                Dictionary<string, int> newMinMax = new Dictionary<string, int>();
                newMinMax.Add("min", number);
                newMinMax.Add("max", number);
                if (minMaxStack.Count > 0)
                {
                    Dictionary<string, int> lastMinMax = new Dictionary<string, int>(
                        minMaxStack[minMaxStack.Count - 1]
                        );
                    newMinMax["min"] = Math.Min(lastMinMax["min"], number);
                    newMinMax["max"] = Math.Max(lastMinMax["max"], number);
                }
                minMaxStack.Add(newMinMax);
                stack.Add(number);
            }

            // O(1) time | O(1) space
            public int GetMin()
            {
                return minMaxStack[minMaxStack.Count - 1]["min"];
            }

            // O(1) time | O(1) space
            public int GetMax()
            {
                return minMaxStack[minMaxStack.Count - 1]["max"];
            }
        }
    }
}