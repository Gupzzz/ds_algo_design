using System;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static void _LongestCommonSubsequence(){
            string str1 = "abcde", str2 = "ace";
            int m = str1.Length, n = str2.Length;
            int[,] dp = new int[m + 1, n + 1];
            Console.WriteLine("[Method1] The longest common subsequence length is " + LongestCommonSubsequence1(str1, str2, m, n));
            Console.WriteLine("[Method2] The longest common subsequence length is " + LongestCommonSubsequence2(str1, str2, m, n, dp));
            Console.WriteLine("[Method3] The longest common subsequence length is " + LongestCommonSubsequence3(str1, str2, m, n));
            Console.WriteLine("[Method4] The longest common subsequence length is " + LongestCommonSubsequence4(str1, str2, m, n));
        }
        // Method1()- recursive solution(Top- down approach)
        // time complexity - O(2^(m+n))
        // space complexity - O(m+n)
        public static int LongestCommonSubsequence1(string X, string Y, int i, int j)
        {
            if (i <= 0 || j <= 0)
                return 0;
            if (X[i - 1] == Y[j - 1])
                return 1 + LongestCommonSubsequence1(X, Y, i - 1, j - 1);
            else
                return Math.Max(LongestCommonSubsequence1(X, Y, i, j - 1), LongestCommonSubsequence1(X, Y, i - 1, j));

        }

        // Method2()- recursive solution with memoization
        // time complexity - O(m*n)
        // space complexity - O(m*n)
        public static int LongestCommonSubsequence2(string X, string Y, int i, int j, int[,] dp)
        {
            if (i <= 0 || j <= 0)
                return 0;

            if (dp[i, j] != 0)
                return dp[i, j];

            if (X[i - 1] == Y[j - 1])
                return 1 + LongestCommonSubsequence2(X, Y, i - 1, j - 1, dp);
            else
                return dp[i, j] = Math.Max(LongestCommonSubsequence2(X, Y, i, j - 1, dp), LongestCommonSubsequence2(X, Y, i - 1, j, dp));

        }

        // Method3()- DP solution(Bottom up approach)
        // time complexity - O(m*n)
        // space complexity - O(m*n)
        public static int LongestCommonSubsequence3(string X, string Y, int m, int n)
        {
            int[,] memo = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        memo[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        memo[i, j] = memo[i - 1, j - 1] + 1;
                    else
                        memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
                }
            }
            return memo[m, n];
        }

        // Method4()- DP solution(Bottom up approach)
        // time complexity - O(m*n)
        // space complexity - O(n)
        public static int LongestCommonSubsequence4(string X, string Y, int m, int n)
        {
            int[] memo = new int[n + 1];

            for (int i = 1; i <= m; i++)
            {
                int prev = 0;
                for (int j = 1; j <= n; j++)
                {
                    int temp = memo[j];
                    if (X[i - 1] == Y[j - 1])
                    {
                        memo[j] = prev + 1;
                    }
                    else
                    {
                        memo[j] = Math.Max(memo[j], memo[j - 1]);
                    }
                    prev = temp;
                }

            }
            return memo[n];
        }

    }
}