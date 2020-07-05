namespace algoexpert
{
    // Water Area

    // You are given an array of integers. Each non-zero integer represents the height of a pillar of width 1. Imagine water being poured over all
    //  of the pillars and return the surface area of the water trapped between the pillars viewed from the front. Note that spilled water should
    //   be ignored. Refer to the first minute of the video explanation below for a visual example.

    // Sample input: [0, 8, 0, 0, 5, 0, 0, 10, 0, 0, 1, 1, 0, 3]
    // Sample output: 48
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System;
    public partial class Program
    {
        // O(n) time | O(n) space
        public static int WaterArea(int[] heights)
        {
            int[] maxes = new int[heights.Length];
            int leftMax = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                int height = heights[i];
                maxes[i] = leftMax;
                leftMax = Math.Max(leftMax, height);
            }
            int rightMax = 0;
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                int height = heights[i];
                int minHeight = Math.Min(rightMax, maxes[i]);
                if (height < minHeight)
                {
                    maxes[i] = minHeight - height;
                }
                else
                {
                    maxes[i] = 0;
                }
                rightMax = Math.Max(rightMax, height);
            }
            int total = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                total += maxes[i];
            }
            return total;
        }
    }
}