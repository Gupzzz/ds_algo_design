namespace algoexpert
{
// ​Find Three Largest Numbers

// Write a function that takes in an array of integers and returns a sorted array of the three
// largest integers in the input array.Note that the function should return duplicate integers 
// if necessary; for example, it should return [10, 10, 12] for an input array of[10, 5, 9, 10, 12].

// Sample input: [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7]
//     Sample output: [18, 141, 541]
using System;
public partial class Program
    {
        // O(n) time | O(1) space
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            int[] threeLargest = { Int32.MinValue, Int32.MinValue, Int32.MinValue };
            foreach (int num in array)
            {
                updateLargest(threeLargest, num);
            }
            return threeLargest;
        }

        public static void updateLargest(int[] threeLargest, int num)
        {
            if (num > threeLargest[2])
            {
                shiftAndUpdate(threeLargest, num, 2);
            }
            else if (num > threeLargest[1])
            {
                shiftAndUpdate(threeLargest, num, 1);
            }
            else if (num > threeLargest[0])
            {
                shiftAndUpdate(threeLargest, num, 0);
            }
        }

        public static void shiftAndUpdate(int[] array, int num, int idx)
        {
            for (int i = 0; i <= idx; i++)
            {
                if (i == idx)
                {
                    array[i] = num;
                }
                else
                {
                    array[i] = array[i + 1];
                }
            }
        }
    }
}