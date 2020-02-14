namespace algoexpert
{
    // Largest Range

    // Write a function that takes in an array of integers and returns an array of length 2 representing the largest range of numbers contained in that array. 
    // The first number in the output array should be the first number in the range while the second number should be the last number in the range. A range 
    // of numbers is defined as a set of numbers that come right after each other in the set of real integers. For instance, the output array [2, 6] 
    // represents the range {2, 3, 4, 5, 6}, which is a range of length 5. Note that numbers do not need to be ordered or adjacent in the array in order 
    // to form a range. Assume that there will only be one largest range.

    // Sample input: [1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6]
    // Sample output: [0, 7]
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System.Collections.Generic;

    public partial class Program
    {
        // O(n) time | O(n) space
        public static int[] LargestRange(int[] array)
        {
            int[] bestRange = new int[2];
            int longestLength = 0;
            Dictionary<int, bool> nums = new Dictionary<int, bool>();
            foreach (int num in array)
            {
                nums[num] = true;
            }
            foreach (int num in array)
            {
                if (!nums[num])
                {
                    continue;
                }
                nums[num] = false;
                int currentLength = 1;
                int left = num - 1;
                int right = num + 1;
                while (nums.ContainsKey(left))
                {
                    nums[left] = false;
                    currentLength++;
                    left--;
                }
                while (nums.ContainsKey(right))
                {
                    nums[right] = false;
                    currentLength++;
                    right++;
                }
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    bestRange = new int[] { left + 1, right - 1 };
                }
            }
            return bestRange;
        }
    }
}