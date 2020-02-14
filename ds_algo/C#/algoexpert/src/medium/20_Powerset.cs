namespace algoexpert
{
// Powerset

// Write a function that takes in an array of unique integers and returns its powerset.The powerset P(X) of a set X 
// is the set of all subsets of X.For example, the powerset of[1, 2] is [[], [1], [2], [1,2]]. Note that the sets 
// in the powerset do not need to be in any particular order.

// Sample input: [1, 2, 3]
//     Sample output: [[], [1], [2], [3], [1, 2], [1, 3], [2, 3], [1, 2, 3]]

using System.Collections.Generic;

public partial class Program
    {
        // O(n*2^n) time | O(n*2^n) space
        public static List<List<int>> Powerset(List<int> array)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());
            foreach (int ele in array)
            {
                int length = subsets.Count;
                for (int i = 0; i < length; i++)
                {
                    List<int> currentSubset = new List<int>(subsets[i]);
                    currentSubset.Add(ele);
                    subsets.Add(currentSubset);
                }
            }
            return subsets;
        }
    }
}