using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        // Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        // (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
        // You are given a target value to search.If found in the array return its index, otherwise return -1.
        // You may assume no duplicate exists in the array.
        // Your algorithm's runtime complexity must be in the order of O(log n).

        // Example 1:
        // Input: nums = [4, 5, 6, 7, 0, 1, 2], target = 0
        // Output: 4

        public static int SearchInRotatedSortedArray(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1, mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if(nums[mid] == target)
                    return mid;
                if (nums[start] <= nums[mid])
                {
                    if (target < nums[mid] && target >= nums[start])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                if (nums[mid] <= nums[end])
                {
                    if (target > nums[mid] && target <= nums[end])
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
            }
            return -1;
        }

        public static void _SearchInRotatedSortedArray()
        {
            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            Console.WriteLine("The target is found at " + SearchInRotatedSortedArray(nums, 0));
        }
    }
}