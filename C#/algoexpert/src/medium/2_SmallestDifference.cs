namespace algoexpert
{
// ​Smallest Difference

// Write a function that takes in two non-empty arrays of integers.The function should find the pair of numbers 
// (one from the first array, one from the second array) whose absolute difference is closest to zero.The function 
// should return an array containing these two numbers, with the number from the first array in the first position.
// Assume that there will only be one pair of numbers with the smallest difference.

// Sample input: [-1, 5, 10, 20, 28, 3], [26, 134, 135, 15, 17]
// Sample output: [28, 26]
using System;

public partial class Program
    {
        // O(nlog(n) + mlog(m)) time | O(1) space
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            int idxOne = 0;
            int idxTwo = 0;
            int smallest = Int32.MaxValue;
            int current = Int32.MaxValue;
            int[] smallestPair = new int[2];
            while (idxOne < arrayOne.Length && idxTwo < arrayTwo.Length)
            {
                int firstNum = arrayOne[idxOne];
                int secondNum = arrayTwo[idxTwo];
                if (firstNum < secondNum)
                {
                    current = secondNum - firstNum;
                    idxOne++;
                }
                else if (secondNum < firstNum)
                {
                    current = firstNum - secondNum;
                    idxTwo++;
                }
                else
                {
                    return new int[] { firstNum, secondNum };
                }
                if (smallest > current)
                {
                    smallest = current;
                    smallestPair = new int[] { firstNum, secondNum };
                }
            }
            return smallestPair;
        }
    }
}