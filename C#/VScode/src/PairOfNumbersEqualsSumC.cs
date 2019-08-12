using System;
using System.Collections.Generic;

// https://www.geeksforgeeks.org/given-an-array-a-and-a-number-x-check-for-pair-in-a-with-sum-as-x/
namespace VScode
{
    class PairOfNumbersEqualsSumC
    {
        public void FindPairOfNumbersEqualsSum(int[] values, int sum)
        {
            HashSet<int> hashTable = new HashSet<int>();
            for (int i = 0; i < values.Length; ++i)
            {
                int temp = sum - values[i];

                // checking for condition 
                if (temp >= 0 && hashTable.Contains(temp))
                {
                    Console.Write("Pair with given sum " +sum + " is (" + values[i] + ", " + temp + ")");
                }
                hashTable.Add(values[i]);
            }
        }
    }
}