using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static void MoveZerosToEnd(int[] nums){
            int left = 0;
            int right = 0;
            int n = nums.Length;
            while (right < n)
            {
                while (left < n && nums[left] != 0)
                    left++;
                while (right < n && nums[right] == 0)
                    right++;
                if (left < n && right < n)
                {
                    nums[left] = nums[right];
                    nums[right] = 0;
                }
            }
        }

        public static void _MoveZerosToEnd(){
            int[] nums = new int[] {0, 1, 0, 3, 12};
            Console.WriteLine("Before movinf zeros");
            foreach (var item in nums)
                Console.Write(item + "\t");
            MoveZerosToEnd(nums);
            Console.WriteLine("\nAfter moving zeros");
            foreach (var item in nums)
                Console.Write(item + "\t");
        }

    }
}