namespace algoexpert
{
// Min Number Of Coins For Change

// Given an array of positive integers representing coin denominations and a single non-negative integer 
// representing a target amount of money, implement a function that returns the smallest number of coins 
// needed to make change for that target amount using the given coin denominations.Note that an unlimited 
// amount of coins is at your disposal.If it is impossible to make change for the target amount, return -1.

// Sample input: 7, [1, 5, 10]
//     Sample output: 3 (2x1 + 1x5)

using System;

public partial class Program
    {
        // O(nd) time | O(n) space
        public static int MinNumberOfCoinsForChange(int n, int[] denoms)
        {
            int[] numOfCoins = new int[n + 1];
            Array.Fill(numOfCoins, Int32.MaxValue);
            numOfCoins[0] = 0;
            int toCompare = 0;
            foreach (int denom in denoms)
            {
                for (int amount = 0; amount < numOfCoins.Length; amount++)
                {
                    if (denom <= amount)
                    {
                        if (numOfCoins[amount - denom] == Int32.MaxValue)
                        {
                            toCompare = numOfCoins[amount - denom];
                        }
                        else
                        {
                            toCompare = numOfCoins[amount - denom] + 1;
                        }
                        numOfCoins[amount] =
                          Math.Min(numOfCoins[amount], toCompare);
                    }
                }
            }
            return numOfCoins[n] != Int32.MaxValue ? numOfCoins[n] : -1;
        }
    }
}