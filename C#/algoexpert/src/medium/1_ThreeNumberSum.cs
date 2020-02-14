namespace algoexpert
{
// ​Three Number Sum

// Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum.
// The function should find all triplets in the array that sum up to the target sum and return a two-dimensional 
// array of all these triplets. The numbers in each triplet should be ordered in ascending order, and the triplets 
// themselves should be ordered in ascending order with respect to the numbers they hold.If no three numbers sum 
// up to the target sum, the function should return an empty array.

// Sample input: [12, 3, 1, 2, -6, 5, -8, 6], 0
// Sample output: [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]
using System;
using System.Collections.Generic;

public partial class Program
    {
        // O(n^2) time | O(n) space
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            List<int[]> triplets = new List<int[]>();
            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;
                while (left < right)
                {
                    int currentSum = array[i] + array[left] + array[right];
                    if (currentSum == targetSum)
                    {
                        int[] newTriplet = { array[i], array[left], array[right] };
                        triplets.Add(newTriplet);
                        left++;
                        right--;
                    }
                    else if (currentSum < targetSum)
                    {
                        left++;
                    }
                    else if (currentSum > targetSum)
                    {
                        right--;
                    }
                }
            }
            return triplets;
        }
    }
}