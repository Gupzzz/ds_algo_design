namespace general
{
    class LengthOfLongestPalindromicSubSequenceC
    {
        public int GetLengthOfLongestPalindromicSubSequenceM(string inputString, int start, int end)
        {
            if (start == end)
            {
                return 1;
            }
            if (end == start + 1 && inputString[start] == inputString[end])
            {
                return 2;
            }
            if (inputString[start] == inputString[end])
            {
                return GetLengthOfLongestPalindromicSubSequenceM(inputString, start + 1, end - 1) + 2;
            }
            else
            {
                return System.Math.Max(
                    GetLengthOfLongestPalindromicSubSequenceM(inputString, start + 1, end),
                    GetLengthOfLongestPalindromicSubSequenceM(inputString, start, end - 1)
                    );
            }
        }
        public int lps(string seq)
        {
            int n = seq.Length;
            int i, j, cl;

            // Create a table to store results of subproblems 
            int[,] L = new int[n, n];

            // Strings of length 1 are palindrome of lentgh 1 
            for (i = 0; i < n; i++)
                L[i, i] = 1;

            // Build the table. Note that the lower diagonal values of table 
            // are useless and not filled in the process. The values are  
            // filled in a manner similar to Matrix Chain Multiplication DP solution (See 
            // https://www.geeksforgeeks.org/matrix-chain-multiplication-dp-8/ 
            // cl is length of substring 
            for (cl = 2; cl <= n; cl++)
            {
                for (i = 0; i < n - cl + 1; i++)
                {
                    j = i + cl - 1;

                    if (seq[i] == seq[j] &&
                                    cl == 2)
                        L[i, j] = 2;
                    else if (seq[i] == seq[j])
                        L[i, j] = L[i + 1, j - 1] + 2;
                    else
                        L[i, j] =
                        max(L[i, j - 1], L[i + 1, j]);
                }
            }
            return L[0, n - 1];
        }

        public int max(int x, int y)
        {
            return (x > y) ? x : y;
        }
    }
}