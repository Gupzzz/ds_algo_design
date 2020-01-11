//​Two Number Sum

//Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum.If any two numbers in the input array sum up to the target sum, the function should return them in an array. If no two numbers sum up to the target sum, the function should return an empty array.Assume that there will be at most one pair of numbers summing up to the target sum.

//Sample input: [3, 5, -4, 8, 11, 1, -1, 6], 10
//Sample output: [-1, 11]

using System;

namespace algoexpert
{
    public partial class Program
    {
        public static void _TwoNumberSum()
        {
            int[] data = { 10, 20, 35, 47, 70, 100, 52 };
            foreach (var item in TwoNumberSum(data, 90))
            {
                Console.Write(item + "\t    ");
            }
        }

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int currentSum = array[left] + array[right];
                if (currentSum == targetSum)
                {
                    return new int[] { array[left], array[right] };
                }
                else if (currentSum < targetSum)
                {
                    left++;
                }
                else if (currentSum > targetSum)
                {
                    right--;
                }
            }
            return new int[0];
        }
    }
}