using System;
using System.Collections.Generic;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
// A binary matrix means that all elements are 0 or 1. For each individual row of the matrix,
//  this row is sorted in non-decreasing order.
// Given a row-sorted binary matrix binaryMatrix, return leftmost column index(0-indexed)
//  with at least a 1 in it.If such index doesn't exist, return -1.
        public static int LeftmostColumnWithOne(int[,] binaryMatrix)
        {
            int m = binaryMatrix.GetLength(0), n = binaryMatrix.GetLength(1);
            int ans = -1, r = 0, c = n - 1;
            while (r < m && c >= 0)
            {
                if (binaryMatrix[r, c] == 1)
                {
                    ans = c; // record as current ans
                    c--;
                }
                else
                {
                    r++;
                }
            }
            return ans;
        }
        public static void _LeftmostColumnWithOne()
        {
            int[,] binaryMatrix = new int[,] {
                { 0, 0, 0, 0 },
                { 0, 0, 1, 1 },
                { 0, 0, 0, 1 }
                };
            Console.WriteLine("Leftmost column is " + LeftmostColumnWithOne(binaryMatrix));
        }
    }
}