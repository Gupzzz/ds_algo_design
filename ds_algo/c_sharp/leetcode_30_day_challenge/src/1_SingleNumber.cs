using System;
using System.Collections;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static int SingleNumber(int[] nums)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (ht.ContainsKey(nums[i]))
                {
                    int t = (int)ht[nums[i]];
                    ht[nums[i]] = t + 1;
                }
                else
                {
                    ht.Add(nums[i], 1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                // Console.WriteLine(nums[i] + "\t" + ht[nums[i]]);
                if ((int)ht[nums[i]] == 1)
                    return nums[i];
            }
            return 0;
        }
        public static void _SingleNumber()
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(nums));
        }
    }
}