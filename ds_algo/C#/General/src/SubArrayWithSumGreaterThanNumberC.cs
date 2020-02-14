using System;

namespace general
{
    public class SubArrayWithSumGreaterThanNumberC
    {
        // Given an array of integers and a number x, find the smallest
        // subarray with sum greater than the given value.
        // Return the sub array's length
        public int SubArrayWithSumGreaterThanNumber(int[] arr, int sum)
        {
            int minLength = arr.Length + 1;
            int start = 0, end = 0;
            int mySum = 0;

            while (end < arr.Length)
            {
                while (mySum <= sum && end < arr.Length)
                {
                    mySum += arr[end ++];                    
                }
                if (mySum <= sum && start == 0 && end == arr.Length)
                {
                    return 0;
                }
                while(mySum > sum) 
                {
                    if (end - start < minLength)
                    {
                        minLength = end - start;
                    }
                    mySum -= arr[start ++];
                } 
            } 
            return minLength;         
        }
    }
}