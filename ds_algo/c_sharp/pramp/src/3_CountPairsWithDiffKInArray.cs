using System;
using System.Collections;
namespace pramp
{
    public partial class Program
    {
        public static int CountPairsWithDiffKInArrayUsingTwoPointers(int[] input, int k)
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
        
        public static int CountPairsWithDiffKInArrayUsingHashTable(int[] input, int k)
        {
            Hashtable indexer = new Hashtable();
            foreach (int item in input)
            {
                indexer.Add(Convert.ToInt32(item), 
                    Convert.ToInt32(item - k));
            }
            int count = 0;
            foreach (int item in input)
            {
                if(indexer.ContainsValue(item))
                    count++;
            }
            return count;
        }

        public static void _CountPairsWithDiffKInArray()
        {
            int[] input = { 5, 10, 100, 200, 150 };
            int k = 50;
            Console.WriteLine("Count of pairs with given diff is " + CountPairsWithDiffKInArrayUsingTwoPointers(input, k) + " [Using two pointer solution]");
            Console.WriteLine("Count of pairs with given diff is " + CountPairsWithDiffKInArrayUsingHashTable(input, k) + " [Using hash table]");
        }
    }
}