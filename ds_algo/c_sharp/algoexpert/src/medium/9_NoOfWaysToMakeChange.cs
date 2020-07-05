namespace algoexpert
{
// Number Of Ways To Make Change

// Given an array of positive integers representing coin denominations and a single non-negative integer 
// representing a target amount of money, implement a function that returns the number of ways to make change 
// for that target amount using the given coin denominations.Note that an unlimited amount of coins is at your 
// disposal.

// Sample input: 6, [1, 5]
//     Sample output: 2 (1x1 + 1x5 and 6x1)

public partial class Program
    {
        // O(nd) time | O(n) space
        public static int NumberOfWaysToMakeChange(int n, int[] denoms)
        {
            int[] ways = new int[n + 1];
            ways[0] = 1;
            foreach (int denom in denoms)
            {
                for (int amount = 1; amount < n + 1; amount++)
                {
                    if (denom <= amount)
                    {
                        ways[amount] += ways[amount - denom];
                    }
                }
            }
            return ways[n];
        }
    }
}