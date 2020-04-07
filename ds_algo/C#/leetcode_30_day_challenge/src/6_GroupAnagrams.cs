using System;
using System.Collections;
using System.Collections.Generic;

namespace leetcode_30_day_challenge {
    public partial class Program {
        public static bool AreTheyAnagram (string s1, string s2) {
            if (s1.Length == s2.Length) {

                Hashtable ht = new Hashtable ();
                for (int i = 0; i < s1.Length; i++) {
                    if (ht.ContainsKey (s1[i])) {
                        int count = Convert.ToInt32 (ht[s1[i]]);
                        ht[s1[i]] = ++count;
                    } else {
                        ht.Add (s1[i], 1);
                    }
                }

                for (int i = 0; i < s1.Length; i++) {
                    if (!ht.ContainsKey (s2[i]))
                        return false;
                    else {
                        int count = Convert.ToInt32 (ht[s2[i]]);
                        ht[s2[i]] = --count;
                    }
                }

                for (int i = 0; i < s1.Length; i++) {
                    if (Convert.ToInt32 (ht[s1[i]]) != 0)
                        return false;
                }
                return true;
            }
            return false;
        }

        public static List<List<string>> GroupAnagrams (string[] strs) {
            int[] visited = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
                visited[i] = 0;

            List<List<string>> groupAnagrams = new List<List<string>> ();
            List<string> row;
            for (int i = 0; i < strs.Length; i++) {
                row = new List<string> ();
                if (visited[i] == 0) {
                    visited[i] = 1;
                    row.Add (strs[i]);
                    for (int j = i + 1; j < strs.Length; j++) {
                        if (visited[j] == 0) {
                            bool IsAnagram = AreTheyAnagram (strs[i], strs[j]);
                            if (IsAnagram) {
                                visited[j] = 1;
                                row.Add (strs[j]);
                            }
                        }
                    }
                    groupAnagrams.Add (row);
                }
            }
            return groupAnagrams;
        }

        public static void _GroupAnagrams () {
            string[] inputs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            Console.WriteLine ("Input : ");
            foreach (var item in inputs) {
                Console.Write (item + "\t");
            }
            Console.WriteLine ("\n\n");
            Console.WriteLine ("Output : ");
            var output = GroupAnagrams (inputs);
            foreach (var item in output) {
                foreach (var x in item) {
                    Console.Write (x + "\t");
                }
                Console.WriteLine ();
            }
        }
    }
}