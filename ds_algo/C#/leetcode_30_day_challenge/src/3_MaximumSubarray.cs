using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static int MaximumSubarray(int[] nums)
        {
            int maxCurrent = 0;
            int maxSoFar = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                maxCurrent = Math.Max(nums[i], maxCurrent + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxCurrent);
            }
            return maxSoFar;
        }
        public static void _MaximumSubarray(){
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4};
            Console.WriteLine("The maximum subarray with largest sum is " + MaximumSubarray(nums));
        }
    }
}