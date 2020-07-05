namespace algoexpert
{
// Max Sum Increasing Subsequence

// Given an non-empty array of integers, write a function that returns an array of length 2. The first element in the output array should be an 
// integer value representing the greatest sum that can be generated from a strictly-increasing subsequence in the array. The second element should 
// be an array of the numbers in that subsequence. A subsequence is defined as a set of numbers that are not necessarily adjacent but that are in the 
// same order as they appear in the array. Assume that there will only be one increasing subsequence with the greatest sum.

// Sample input: [10, 70, 20, 30, 50, 11, 30]
// Sample output: [110, [10, 20, 30, 50]]
// Copyright © 2020 AlgoExpert, LLC. All rights reserved.
    using System;
    using System.Collections.Generic;

    public partial class Program
    {
        // O(n^2) time | O(n) space
        public static List<List<int>> MaxSumIncreasingSubsequence(int[] array)
        {
            int[] sequences = new int[array.Length];
            Array.Fill(sequences, Int32.MinValue);
            int[] sums = (int[])array.Clone();
            int maxSumIdx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                for (int j = 0; j < i; j++)
                {
                    int otherNum = array[j];
                    if (otherNum < currentNum && sums[j] + currentNum >= sums[i])
                    {
                        sums[i] = sums[j] + currentNum;
                        sequences[i] = j;
                    }
                }
                if (sums[i] >= sums[maxSumIdx])
                {
                    maxSumIdx = i;
                }
            }
            return buildSequence(array, sequences, maxSumIdx, sums[maxSumIdx]);
        }

        public static List<List<int>> buildSequence(int[] array, int[] sequences, int currentIdx,
          int sums)
        {
            List<List<int>> sequence = new List<List<int>>();
            sequence.Add(new List<int>());
            sequence.Add(new List<int>());
            sequence[0].Add(sums);
            while (currentIdx != Int32.MinValue)
            {
                sequence[1].Insert(0, array[currentIdx]);
                currentIdx = sequences[currentIdx];
            }
            return sequence;
        }
    }
}