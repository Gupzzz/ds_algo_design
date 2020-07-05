using System;
using System.Collections;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static int ContiguousArrayOf0And1(int[] nums)
        {
            Hashtable ht = new Hashtable();
            ht.Add(0, -1);
            int maxlen = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count = count + (nums[i] == 1 ? 1 : -1);
                if (ht.ContainsKey(count))
                {
                    maxlen = Math.Max(maxlen, i - (int)ht[count]);
                }
                else
                {
                    ht.Add(count, i);
                }
            }
            return maxlen;
        }
        public static void _ContiguousArrayOf0And1(){
            int[] nums = new int[] { 0, 1, 0, 0 };
            Console.WriteLine("Contiguous number of 1s and 0s is " + ContiguousArrayOf0And1(nums));
        }
    }
}