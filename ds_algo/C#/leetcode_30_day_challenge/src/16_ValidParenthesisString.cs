using System;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static bool ValidParenthesisString(string s)
        {
            int n = s.Length;
            if (n == 0) return true;
            bool[,] dp = new bool[n, n];

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '*') dp[i, i] = true;
                if (i < n - 1 &&
                        (s[i] == '(' || s[i] == '*') &&
                        (s[i + 1] == ')' || s[i + 1] == '*'))
                {
                    dp[i, i + 1] = true;
                }
            }

            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++){
            //         Console.Write(dp[i, j] + "\t");
            //     }
            //     Console.WriteLine();
            // }

            for (int size = 2; size < n; size++)
                {
                    for (int i = 0; i + size < n; i++)
                    {
                        if (s[i] == '*' && dp[i + 1, i + size] == true)
                        {
                            dp[i, i + size] = true;
                        }
                        else if (s[i] == '(' || s[i] == '*')
                        {
                            for (int k = i + 1; k <= i + size; k++)
                            {
                                if ((s[k] == ')' || s[k] == '*') &&
                                        (k == i + 1 || dp[i + 1, k - 1]) &&
                                        (k == i + size || dp[k + 1, i + size]))
                                {
                                    dp[i, i + size] = true;
                                }
                            }
                        }
                    }
                }
            return dp[0, n - 1];
        }
        public static void _ValidParenthesisString(){
            Console.WriteLine("Check if the string is valid " + ValidParenthesisString("(*))"));
        }
    }
}