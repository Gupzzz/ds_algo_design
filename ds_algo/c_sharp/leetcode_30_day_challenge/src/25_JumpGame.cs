using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static bool JumpGame(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > max) { return false; }
                max = Math.Max(nums[i] + i, max);
            }
            return true;
        }
        public static void _JumpGame()
        {
            int[] nums = new int[] { 2, 3, 1, 1, 4};
            foreach (var item in nums)
                Console.Write(item + "\t");
            Console.WriteLine("\nWill be we able to reach the end : " + JumpGame(nums));
        }
    }
}