using System;
using System.Collections;

namespace leetcode_30_day_challenge {
    public partial class Program {
        public static int CountingNumbers (int[] inputs) {
            Hashtable ht = new Hashtable ();
            for (int i = 0; i < inputs.Length; i++) {
                if (ht.ContainsKey (inputs[i])) {
                    int value = (int) ht[inputs[i]];
                    ht[inputs[i]] = ++value;
                } else {
                    ht.Add(inputs[i], 1);
                }
            }

            int maxCount = 0;
            for (int i = 0; i < inputs.Length; i++){
                if(ht.ContainsKey(inputs[i] + 1)){
                    maxCount++;
                }
                // int localLower = inputs[i] - 1, localHigher = inputs[i] + 1, count = 0;
                // while(ht.ContainsKey(localLower)){
                //     count += (int)ht[localLower];
                //     localLower--;
                // }
                // while (ht.ContainsKey(localHigher)){
                //     count += (int)ht[localHigher];
                //     localHigher++;
                // }
                // maxCount = Math.Max(maxCount, count);
            }
            return maxCount;
        }

        public static void _CountingNumbers () {
            int[] inputs = new int[] { 1, 2, 3};
            Console.WriteLine (CountingNumbers (inputs));
        }
    }
}