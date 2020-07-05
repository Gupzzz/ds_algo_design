using System;
using System.Collections.Generic;

namespace general
{
    class SortedSquaredArray
    {
       public int[] run(int[] input){
            int[] result = new int[input.Length];
            int left = 0;
            int right = input.Length - 1;
            int counter = input.Length - 1;

            while(left <= right)
                if(Math.Abs(input[left]) >= Math.Abs(input[right]))
                    result[counter--] = Convert.ToInt32(Math.Pow(input[left++], 2));
                else
                    result[counter--] = Convert.ToInt32(Math.Pow(input[right--], 2));
            return result;
        }

        // public int[] run(int[] input)
        // {
        //    int first = 0, last = input.Length - 1;
        //    int[] output = new int[input.Length];
        //    int j = input.Length - 1;
        //    //Console.WriteLine(j);
        //    while(first <= last)
        //    {
        //        if(input[first] < 0)
        //        {
        //            input[first] = input[first] * - 1;
        //        }
        //        //Console.WriteLine(first); 
        //         if(input[first] > input[last])
        //         {
        //            //Console.WriteLine(first); 
        //            output[j] = input[first];
        //            j--;
        //            first++;
        //        }
        //         else if(input[first] < input[last])
        //        {
        //            output[j] = input[last];
        //            last--;
        //            j--;
        //        }
        //         else
        //         {
        //             output[j] = input[last];
        //             last--;
        //             first++;
        //             j--;
        //          }
        //    } 
        //    for(int i = 0; i < input.Length; i++)
        //    {
        //        output[i] = output[i] * output[i];
        //    }
        //     return output;
        // }
    }
}