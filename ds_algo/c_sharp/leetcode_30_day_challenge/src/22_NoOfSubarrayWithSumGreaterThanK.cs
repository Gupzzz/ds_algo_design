using System;
using System.Collections.Generic;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static int NoOfSubarrayWithSumGreaterThanK(int[] nums, int k){
            int sum = 0, result = 0;
            Dictionary<int, int> preSum = new Dictionary<int, int>();
            preSum.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (preSum.ContainsKey(sum - k))
                {
                    result += preSum[sum - k];
                }
                preSum.Add(sum, preSum.GetValueOrDefault(sum, 0) + 1);
            }

            return result;
        }
        public static void _NoOfSubarrayWithSumGreaterThanK(){
            int[] nums = new int[] { 1, 1, 1};
            Console.WriteLine("The number of subarrays " + NoOfSubarrayWithSumGreaterThanK(nums, 2));
        }
    }
}