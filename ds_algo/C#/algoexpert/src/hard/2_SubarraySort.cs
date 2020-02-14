namespace algoexpert
{
    // Subarray Sort

    // Write a function that takes in an array of integers of length at least 2. The function should return an array of the starting and ending indices 
    // of the smallest subarray in the input array that needs to be sorted in place in order for the entire input array to be sorted. If the input array 
    // is already sorted, the function should return [-1, -1].

    // Sample input: [1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19]
    // Sample output: [3, 9]
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System;
    public partial class Program
    {
        // O(n) time | O(1) space
        public static int[] SubarraySort(int[] array)
        {
            int minOutOfOrder = Int32.MaxValue;
            int maxOutOfOrder = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                if (isOutOfOrder(i, num, array))
                {
                    minOutOfOrder = Math.Min(minOutOfOrder, num);
                    maxOutOfOrder = Math.Max(maxOutOfOrder, num);
                }
            }
            if (minOutOfOrder == Int32.MaxValue)
            {
                return new int[] { -1, -1 };
            }
            int subarrayLeftIdx = 0;
            while (minOutOfOrder >= array[subarrayLeftIdx])
            {
                subarrayLeftIdx++;
            }
            int subarrayRightIdx = array.Length - 1;
            while (maxOutOfOrder <= array[subarrayRightIdx])
            {
                subarrayRightIdx--;
            }
            return new int[] { subarrayLeftIdx, subarrayRightIdx };
        }

        public static bool isOutOfOrder(int i, int num, int[] array)
        {
            if (i == 0)
            {
                return num > array[i + 1];
            }
            if (i == array.Length - 1)
            {
                return num < array[i - 1];
            }
            return num > array[i + 1] || num < array[i - 1];
        }
    }
}