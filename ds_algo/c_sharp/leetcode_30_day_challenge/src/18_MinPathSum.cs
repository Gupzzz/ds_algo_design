using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {

// Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which
// minimizes the sum of all numbers along its path.
// Note: You can only move either down or right at any point in time.
        public static int MinPathSum(int[,] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            int[,] sum = new int[m, n];

            sum[0, 0] = grid[0, 0];
            for (int i = 1; i < m; i++)
                sum[i, 0] = sum[i - 1, 0] + grid[i, 0];
            for (int j = 1; j < n; j++)
                sum[0, j] = sum[0, j - 1] + grid[0, j];

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    sum[i, j] = grid[i, j] + Math.Min(sum[i - 1, j], sum[i, j - 1]);
                }
            }

            return sum[m - 1, n - 1];
        }
        public static void _MinPathSum()
        {
            int[,] grid = new int[,] {
                {1, 3, 1},
                {1, 5, 1},
                {4, 2, 1}
            };

            Console.WriteLine("The min path sum is " + MinPathSum(grid));
        }
    }
}