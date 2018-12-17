using System;
using System.Collections.Generic;

namespace VScode
{
    public class DuplicatesInArrayC
    {
        public int[] DuplicatesInArray(int[] arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[Math.Abs(arr[i])] > 0)
                {
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                }
                else
                {
                    result.Add(Math.Abs(arr[i]));
                }
            }
            return result.ToArray();
        }
    }
}