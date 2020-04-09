using System;
using System.Collections;
using System.Collections.Generic;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static string SimplifyString(string str){
            string result = "";
            Stack<char> s = new Stack<char>();
            foreach(char c in str){
                if (c == '#')
                {
                    if(s.Count != 0){
                        s.Pop();
                    }
                }
                else
                    s.Push(c);
            }
            while(s.Count != 0)
                result += s.Pop();
            return result;
        }
        public static bool BackspaceStringCompare(string str1, string str2){
            return SimplifyString(str1).Equals(SimplifyString(str2));
        }
        public static void _BackspaceStringCompare(){
            Console.WriteLine("The strings are : " + BackspaceStringCompare("aab##c", "abd##c"));
        }
    }
}