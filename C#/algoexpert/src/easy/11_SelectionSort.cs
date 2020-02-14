namespace algoexpert
{
// ​Selection Sort

// Write a function that takes in an array of integers and returns a sorted version of that array.
// Use the Selection Sort algorithm to sort the array.

// If you're unfamiliar with Selection Sort, we recommend watching the Conceptual Overview section 
// of this question's video explanation before starting to code.

// Sample input: [8, 5, 2, 9, 5, 6, 3]
// Sample output: [2, 3, 5, 5, 6, 8, 9]
public partial class Program
    {
        // Best: O(n^2) time | O(1) space
        // Average: O(n^2) time | O(1) space
        // Worst: O(n^2) time | O(1) space
        public static int[] SelectionSort(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[] { };
            }
            int startIdx = 0;
            while (startIdx < array.Length - 1)
            {
                int smallestIdx = startIdx;
                for (int i = startIdx + 1; i < array.Length; i++)
                {
                    if (array[smallestIdx] > array[i])
                    {
                        smallestIdx = i;
                    }
                }
                swap(startIdx, smallestIdx, array);
                startIdx++;
            }
            return array;
        }
    }
}