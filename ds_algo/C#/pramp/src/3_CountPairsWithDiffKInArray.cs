using System;

namespace pramp
{
    public partial class Program
    {
        public static int CountPairsWithDiffKInArray(int[] input, int k)
        {
            int[] localInput = input;
            Array.Sort(localInput);
            int left = 0;
            int right = 0;
            int count = 0;

            while (right < input.Length)
            {
                int difference = localInput[right] - localInput[left];
                if (difference == k)
                {
                    count++;
                    left++;
                    right++;
                }
                else if (difference > k)
                {
                    left++;
                }
                else
                {
                    right++;
                }
            }

            return count;
        }
        public static void _CountPairsWithDiffKInArray()
        {
            int[] input = { 5, 10, 100, 200, 150 };
            int k = 50;
            Console.Write("Count of pairs with given diff is " + CountPairsWithDiffKInArray(input, k));
        }
    }
}