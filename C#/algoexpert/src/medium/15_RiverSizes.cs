namespace algoexpert
{
// River Sizes

// You are given a two-dimensional array(matrix) of potentially unequal height and width containing only 0s and 1s.
// Each 0 represents land, and each 1 represents part of a river.A river consists of any number of 1s that are 
// either horizontally or vertically adjacent(but not diagonally adjacent). The number of adjacent 1s forming a 
// river determine its size.Write a function that returns an array of the sizes of all rivers represented in the 
// input matrix.Note that these sizes do not need to be in any particular order.

// Sample input:
// [
//   [1, 0, 0, 1, 0],
//   [1, 0, 1, 0, 0],
//   [0, 0, 1, 0, 1],
//   [1, 0, 1, 0, 1],
//   [1, 0, 1, 1, 0],
// ]
// Sample output: [1, 2, 2, 2, 5]

using System.Collections.Generic;

public partial class Program
    {
        // O(wh) time | O(wh) space
        public static List<int> RiverSizes(int[,] matrix)
        {
            List<int> sizes = new List<int>();
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (visited[i, j])
                    {
                        continue;
                    }
                    traverseNode(i, j, matrix, visited, sizes);
                }
            }
            return sizes;
        }

        public static void traverseNode(int i, int j, int[,] matrix, bool[,] visited,
          List<int> sizes)
        {
            int currentRiverSize = 0;
            List<int[]> nodesToExplore = new List<int[]>();
            nodesToExplore.Add(new int[] { i, j });
            while (nodesToExplore.Count != 0)
            {
                int[] currentNode = nodesToExplore[nodesToExplore.Count - 1];
                nodesToExplore.RemoveAt(nodesToExplore.Count - 1);
                i = currentNode[0];
                j = currentNode[1];
                if (visited[i, j])
                {
                    continue;
                }
                visited[i, j] = true;
                if (matrix[i, j] == 0)
                {
                    continue;
                }
                currentRiverSize++;
                List<int[]> unvisitedNeighbors =
                  getUnvisitedNeighbors(i, j, matrix, visited);
                foreach (int[] neighbor in unvisitedNeighbors)
                {
                    nodesToExplore.Add(neighbor);
                }
            }
            if (currentRiverSize > 0)
            {
                sizes.Add(currentRiverSize);
            }
        }

        public static List<int[]> getUnvisitedNeighbors(int i, int j, int[,] matrix, bool[,
    ] visited)
        {
            List<int[]> unvisitedNeighbors = new List<int[]>();
            if (i > 0 && !visited[i - 1, j])
            {
                unvisitedNeighbors.Add(new int[] { i - 1, j });
            }
            if (i < matrix.GetLength(0) - 1 && !visited[i + 1, j])
            {
                unvisitedNeighbors.Add(new int[] { i + 1, j });
            }
            if (j > 0 && !visited[i, j - 1])
            {
                unvisitedNeighbors.Add(new int[] { i, j - 1 });
            }
            if (j < matrix.GetLength(1) - 1 && !visited[i, j + 1])
            {
                unvisitedNeighbors.Add(new int[] { i, j + 1 });
            }
            return unvisitedNeighbors;
        }
    }
}