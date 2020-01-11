namespace algoexpert
{
// Maximum Subset Sum With No Adjacent Elements

// Write a function that takes in an array of positive integers and returns an integer representing the maximum 
// sum of non-adjacent elements in the array.If a sum cannot be generated, the function should return 0.

// Sample input: [75, 105, 120, 75, 90, 135]
// Sample output: 330 (75, 120, 135)

using System;
public partial class Program
    {
        // O(n) time | O(1) space
        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            else if (array.Length == 1)
            {
                return array[0];
            }
            int second = array[0];
            int first = Math.Max(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                int current = Math.Max(first, second + array[i]);
                second = first;
                first = current;
            }
            return first;
        }
    }
}