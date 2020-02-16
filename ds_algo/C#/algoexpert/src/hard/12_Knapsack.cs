namespace algoexpert
{
    // ​Knapsack Problem

    // You are given an array of arrays. Each subarray in this array holds two integer values and represents an item; the first integer is the item's
    //  value, and the second integer is the item's weight. You are also given an integer representing the maximum capacity of a knapsack that you
    //   have. Your goal is to fit items in your knapsack, all the while maximizing their combined value. Note that the sum of the weights of the
    //    items that you pick cannot exceed the knapsack's capacity. Write a function that returns the maximized combined value of the items that
    //     you should pick, as well as an array of the indices of each item picked. Assume that there will only be one combination of items that
    //      maximizes the total value in the knapsack.

    // Sample input: [[1, 2], [4, 3], [5, 6], [6, 7]], 10
    // Sample output: [10, [1, 3]]
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System;
    using System.Collections.Generic;

    public partial class Program
    {
        // O(nc) time | O(nc) space
        public static List<List<int>> KnapsackProblem(int[,] items, int capacity)
        {
            int[,] knapsackValues = new int[items.GetLength(0) + 1, capacity + 1];
            for (int i = 1; i < items.GetLength(0) + 1; i++)
            {
                int currentWeight = items[i - 1, 1];
                int currentValue = items[i - 1, 0];
                for (int c = 0; c < capacity + 1; c++)
                {
                    if (currentWeight > c)
                    {
                        knapsackValues[i, c] = knapsackValues[i - 1, c];
                    }
                    else
                    {
                        knapsackValues[i, c] = Math.Max(knapsackValues[i - 1, c],
                            knapsackValues[i - 1,
                            c -
                            currentWeight] +
                            currentValue);
                    }
                }
            }
            return getKnapsackItems(knapsackValues, items,
                     knapsackValues[items.GetLength(0), capacity]);
        }

        public static List<List<int>> getKnapsackItems(int[,] knapsackValues, int[,] items,
          int weight)
        {
            List<List<int>> sequence = new List<List<int>>();
            List<int> totalWeight = new List<int>();
            totalWeight.Add(weight);
            sequence.Add(totalWeight);
            sequence.Add(new List<int>());
            int i = knapsackValues.GetLength(0) - 1;
            int c = knapsackValues.GetLength(1) - 1;
            while (i > 0)
            {
                if (knapsackValues[i, c] == knapsackValues[i - 1, c])
                {
                    i--;
                }
                else
                {
                    sequence[1].Insert(0, i - 1);
                    c -= items[i - 1, 1];
                    i--;
                }
                if (c == 0)
                {
                    break;
                }
            }
            return sequence;
        }
    }
}