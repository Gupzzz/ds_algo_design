using System;
using System.Collections.Generic;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static int LastStoneWeight(List<int> stoneWeights){
            while(stoneWeights.Count > 2){
                stoneWeights.Sort(new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
                
                int one = stoneWeights[0];
                stoneWeights.RemoveAt(0);

                int two = stoneWeights[0];
                stoneWeights.RemoveAt(0);

                int result = one - two;
                if(result != 0)
                {
                    stoneWeights.Add(result);
                }
            }
            return stoneWeights[0];
        }
        public static void _LastStoneWeight(){
            List<int> arr = new List<int>(){ 2, 7, 4, 1, 8, 1 };
            int n = arr.Count;
            Console.WriteLine("The last stone weight is " + LastStoneWeight(arr));
        }
    }
}