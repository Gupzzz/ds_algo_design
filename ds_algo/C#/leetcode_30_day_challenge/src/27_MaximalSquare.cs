using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static int MaximalSquare(int[,] grid)
        {
            if (grid.Length == 0) return 0;
            int m = grid.GetLength(0), n = grid.GetLength(1), result = 0;
            // Console.WriteLine("m and n " + m + "\t" + n);
            int[,] local = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (grid[i - 1, j - 1] == 1)
                    {
                        local[i, j] = Math.Min(Math.Min(local[i, j - 1], local[i - 1, j - 1]), local[i - 1, j]) + 1;
                        result = Math.Max(local[i, j], result); // update result
                    }
                }
            }
            return result * result;
        }
        public static void _MaximalSquare()
        {
            int[,] grid = new int[,] {
                {1, 0, 1, 0, 0},
                {1, 0, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 0, 0, 1, 0}
            };
            Console.WriteLine("Maximal square value is "+ MaximalSquare(grid));
        }
    }
}