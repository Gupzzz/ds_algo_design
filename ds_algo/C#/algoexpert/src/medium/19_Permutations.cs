namespace algoexpert
{
// Permutations

// Write a function that takes in an array of unique integers and returns an array of all permutations of those 
// integers.If the input array is empty, your function should return an empty array.

// Sample input: [1, 2, 3]
//     Sample output: [[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]]

using System.Collections.Generic;

public partial class Program
    {
        // O(n*n!) time | O(n*n!) space
        public static List<List<int>> GetPermutations(List<int> array)
        {
            List<List<int>> permutations = new List<List<int>>();
            GetPermutations(0, array, permutations);
            return permutations;
        }

        public static void GetPermutations(int i, List<int> array, List<List<int>> permutations)
        {
            if (i == array.Count - 1)
            {
                permutations.Add(new List<int>(array));
            }
            else
            {
                for (int j = i; j < array.Count; j++)
                {
                    swap(array, i, j);
                    GetPermutations(i + 1, array, permutations);
                    swap(array, i, j);
                }
            }
        }

        public static void swap(List<int> array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}