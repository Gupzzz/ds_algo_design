namespace algoexpert
{
// ​Move Element To End

// You are given an array of integers and an integer.Write a function that moves all instances of that integer 
// in the array to the end of the array. The function should perform this in place and does not need to maintain 
// the order of the other integers.

// Sample input: [2, 1, 2, 2, 2, 3, 4, 2], 2
// Sample output: [1, 3, 4, 2, 2, 2, 2, 2] (the numbers 1, 3, and 4 could be ordered differently)

using System.Collections.Generic;

public partial class Program
    {
        // O(n) time | O(1) space - where n is the length of the array
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            int i = 0;
            int j = array.Count - 1;
            while (i < j)
            {
                while (i < j && array[j] == toMove) j--;
                if (array[i] == toMove) swap(i, j, array);
                i++;
            }
            return array;
        }

        public static void swap(int i, int j, List<int> array)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}