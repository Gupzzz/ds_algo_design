namespace algoexpert
{
// Kadane's Algorithm

// Write a function that takes in a non-empty array of integers and returns the maximum sum that can be obtained 
// by summing up all the numbers in a non-empty subarray of the input array.A subarray must only contain adjacent 
// numbers.

// Sample input: [3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4]
// Sample output: 19 ([1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1])

using System;
public partial class Program
    {
        // O(n) time | O(1) space
        public static int KadanesAlgorithm(int[] array)
        {
            int maxEndingHere = array[0];
            int maxSoFar = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int num = array[i];
                maxEndingHere = Math.Max(num, maxEndingHere + num);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }
    }
}