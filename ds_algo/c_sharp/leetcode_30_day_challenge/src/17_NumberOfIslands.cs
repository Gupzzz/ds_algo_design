using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static int NumberOfIslands(int[,] grid)
        {
            int count = 0;
            int n = grid.GetLength(0);
            if (n == 0) return 0;
            int m = grid.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (grid[i, j] == 1)
                    {
                        DFSMarking(grid, i, j, n, m);
                        ++count;
                    }
            }
            return count;
        }

        private static void DFSMarking(int[,] grid, int i, int j, int n, int m)
        {
            if (i < 0 || j < 0 || i >= n || j >= m || grid[i, j] != 1) return;
            grid[i, j] = 0;
            DFSMarking(grid, i + 1, j, n, m);
            DFSMarking(grid, i - 1, j, n, m);
            DFSMarking(grid, i, j + 1, n, m);
            DFSMarking(grid, i, j - 1, n, m);
        }

        public static void _NumberOfIslands()
        {
            int[,] grid = new int[,] {
                {1, 1, 0, 0, 0},
                {1, 1, 0, 0, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 1, 1}
            };
            Console.WriteLine("The number of islands is " + NumberOfIslands(grid));
        }
    }
}