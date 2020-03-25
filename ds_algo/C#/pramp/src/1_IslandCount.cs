using System;
using System.Collections.Generic;

namespace pramp
{
    public partial class Program
    {
        public static int IslandCount(int[,] inputGrid)
        {
            int n = inputGrid.GetLength(0);
            int m = inputGrid.GetLength(1);
            int count = 0;
            bool[,] visited = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    visited[i, j] = false;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (inputGrid[i, j] == 1 && !visited[i, j])
                    {
                        DepthFirstTraversalOfGrid(i, j, inputGrid, visited);
                        count++;
                    }
                }
            }
            return count;
        }
        public static void DepthFirstTraversalOfGrid(int k, int l, int[,] inputGrid, bool[,] visited)
        {
            Queue<int[]> neighbours = new Queue<int[]>();
            neighbours.Enqueue(new int[] { k, l });
            while (neighbours.Count != 0)
            {
                int[] processingNode = neighbours.Dequeue();
                int i = processingNode[0];
                int j = processingNode[1];
                visited[i, j] = true;

                // Adding all non visited, valid (1) neighbours to the queue
                if (i > 0 && !visited[i - 1, j] && inputGrid[i - 1, j] == 1)
                    neighbours.Enqueue(new int[] { i - 1, j });
                if (j > 0 && !visited[i, j - 1] && inputGrid[i, j - 1] == 1)
                    neighbours.Enqueue(new int[] { i, j - 1 });
                if (i < inputGrid.GetLength(0) - 1 && !visited[i + 1, j] && inputGrid[i + 1, j] == 1)
                    neighbours.Enqueue(new int[] { i + 1, j });
                if (j < inputGrid.GetLength(1) - 1 && !visited[i, j + 1] && inputGrid[i, j + 1] == 1)
                    neighbours.Enqueue(new int[] { i, j + 1 });
            }
        }
        public static void _IslandCount()
        {
            int[,] inputGrid = new int[,] {
                {1, 1, 0, 0, 0},
                {1, 1, 0, 0, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 1, 1},
            };
            Console.WriteLine("Count of islands is: " + IslandCount(inputGrid));
        }
    }
}