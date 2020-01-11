namespace algoexpert
{
// ​Binary Search

// Write a function that takes in a sorted array of integers as well as a target integer.
// The function should use the Binary Search algorithm to find if the target number is contained 
// in the array and should return its index if it is, otherwise -1.

// Sample input: [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 33
// Sample output: 3
public partial class Program
    {
        // O(log(n)) time | O(log(n)) space
        public static int BinarySearch(int[] array, int target)
        {
            return BinarySearch(array, target, 0, array.Length - 1);
        }

        public static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            int middle = (left + right) / 2;
            int potentialMatch = array[middle];
            if (target == potentialMatch)
            {
                return middle;
            }
            else if (target < potentialMatch)
            {
                return BinarySearch(array, target, left, middle - 1);
            }
            else
            {
                return BinarySearch(array, target, middle + 1, right);
            }
        }
    }
}