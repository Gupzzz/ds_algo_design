using System;

// Input: s = "abcdefg", shift = [[1,1],[1,1],[0,2],[1,3]]
// Output: "efgabcd"
// Explanation:  
// [1,1] means shift to right by 1. "abcdefg" -> "gabcdef"
// [1,1] means shift to right by 1. "gabcdef" -> "fgabcde"
// [0,2] means shift to left by 2. "fgabcde" -> "abcdefg"
// [1,3] means shift to right by 3. "abcdefg" -> "efgabcd"

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static string PerformStringShifts(string str, int[,] shift)
        {
            int totalLeftShift = 0, totalRightShift = 0;
            for (int i = 0; i < shift.GetLength(0); i++)
            {
                if (shift[i,0] == 0)
                    totalLeftShift += shift[i, 1];
                else
                    totalRightShift += shift[i, 1];
            }
            if (totalLeftShift > totalRightShift)
                str = LeftShift(str, totalLeftShift - totalRightShift);
            else
                str = RightShift(str, totalRightShift - totalLeftShift);
            return str;
        }

        public static string RightShift(string str, int n)
        {
            n = n > str.Length ? n % str.Length : n;
            return LeftShift(str, str.Length - n);
        }

        public static string LeftShift(string str, int n)
        {
            n = n > str.Length ? n % str.Length : n;
            return str.Substring(n, str.Length - n) + str.Substring(0, n);
        }

        public static void _PerformStringShifts()
        {
            string str = "yisxjwry";
            int[,] shift = new int[,] { { 1, 8 }, { 1, 4 }, { 1, 3 }, { 1, 6 }, { 0, 6 },
                    { 1, 4 }, { 0, 2 }, {0, 1}};
            Console.WriteLine("The output after shifts is " + PerformStringShifts(str, shift));
        }
    }
}