namespace algoexpert
{
    // Min Number Of Jumps

    // You are given a non-empty array of integers. Each element represents the maximum number of steps you can take forward. For example, if the element 
    // at index 1 is 3, you can go from index 1 to index 2, 3, or 4. Write a function that returns the minimum number of jumps needed to reach the final 
    // index. Note that jumping from index i to index i + x always constitutes 1 jump, no matter how large x is.

    // Sample input: [3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3]
    // Sample output: 4 (3 --> 4 or 2 --> 2 or 3 --> 7 --> 3)
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System;
    public partial class Program
    {
        // O(n) time | O(1) space
        public static int MinNumberOfJumps(int[] array)
        {
            if (array.Length == 1)
            {
                return 0;
            }
            int jumps = 0;
            int maxReach = array[0];
            int steps = array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                maxReach = Math.Max(maxReach, i + array[i]);
                steps--;
                if (steps == 0)
                {
                    jumps++;
                    steps = maxReach - i;
                }
            }
            return jumps + 1;
        }
    }
}