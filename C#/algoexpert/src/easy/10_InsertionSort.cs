namespace algoexpert
{
// ​Insertion Sort

// Write a function that takes in an array of integers and returns a sorted version of that array.
// Use the Insertion Sort algorithm to sort the array.

// If you're unfamiliar with Insertion Sort, we recommend watching the Conceptual Overview section 
// of this question's video explanation before starting to code.

// Sample input: [8, 5, 2, 9, 5, 6, 3]
// Sample output: [2, 3, 5, 5, 6, 8, 9]
public partial class Program
    {
        // Best: O(n) time | O(1) space
        // Average: O(n^2) time | O(1) space
        // Worst: O(n^2) time | O(1) space
        public static int[] InsertionSort(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[] { };
            }
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    swap(j, j - 1, array);
                    j -= 1;
                }
            }
            return array;
        }
    }
}