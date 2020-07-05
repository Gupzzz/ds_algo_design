namespace algoexpert
{
// Search In Sorted Matrix

// You are given a two-dimensional array(matrix) of distinct integers where each row is sorted and each column is 
// also sorted.The matrix does not necessarily have the same height and width. You are also given a target number, 
// and you must write a function that returns an array of the row and column indices of the target number if it is 
// contained in the matrix and[-1, -1] if it is not contained in the matrix.


// Sample input:
// [

//     [1, 4, 7, 12, 15, 1000],
//    [2, 5, 19, 31, 32, 1001],
//    [3, 8, 24, 33, 35, 1002],
//    [40, 41, 42, 44, 45, 1003],
//    [99, 100, 103, 106, 128, 1004],
// ], 44
// Sample output: [3, 3]

public partial class Program
    {
        // O(n) time | O(1) space
        public static int[] SearchInSortedMatrix(int[,] matrix, int target)
        {
            int row = 0;
            int col = matrix.GetLength(1) - 1;
            while (row < matrix.GetLength(0) && col >= 0)
            {
                if (matrix[row, col] > target)
                {
                    col--;
                }
                else if (matrix[row, col] < target)
                {
                    row++;
                }
                else
                {
                    return new int[] { row, col };
                }
            }
            return new int[] { -1, -1 };
        }
    }
}