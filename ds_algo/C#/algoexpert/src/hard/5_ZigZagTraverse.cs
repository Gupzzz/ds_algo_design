namespace algoexpert
{
    // Zigzag Traverse

    // Write a function that takes in a square-shaped (n x n) two-dimensional array and returns a one-dimensional array of all the array's elements in 
    // zigzag order. Zigzag order starts at the top left corner of the two-dimensional array, goes down by one element, and proceeds in a zigzag pattern 
    // all the way to the bottom right corner.

    // Sample input:
    // [
    //   [1, 3, 4, 10],
    //   [2, 5, 9, 11],
    //   [6, 8, 12, 15],
    //   [7, 13, 14, 16],
    // ]
    // Sample output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16]
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System.Collections.Generic;

    // O(n) time | O(n) space - where n is the total number of elements in the two-dimensional array
    public partial class Program
    {
        public static List<int> ZigzagTraverse(List<List<int>> array)
        {
            int height = array.Count - 1;
            int width = array[0].Count - 1;
            List<int> result = new List<int>();
            int row = 0;
            int col = 0;
            bool goingDown = true;
            while (!isOutOfBounds(row, col, height, width))
            {
                result.Add(array[row][col]);
                if (goingDown)
                {
                    if (col == 0 || row == height)
                    {
                        goingDown = false;
                        if (row == height)
                        {
                            col++;
                        }
                        else
                        {
                            row++;
                        }
                    }
                    else
                    {
                        row++;
                        col--;
                    }
                }
                else
                {
                    if (row == 0 || col == width)
                    {
                        goingDown = true;
                        if (col == width)
                        {
                            row++;
                        }
                        else
                        {
                            col++;
                        }
                    }
                    else
                    {
                        row--;
                        col++;
                    }
                }
            }
            return result;
        }

        public static bool isOutOfBounds(int row, int col, int height, int width)
        {
            return row < 0 || row > height || col < 0 || col > width;
        }
    }
}