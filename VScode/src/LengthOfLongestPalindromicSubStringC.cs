class LengthOfLongestPalindromicSubStringC{
    public int GetLengthOfLongestPalindromicSubStringM(string inputString, int start, int end){
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
            return GetLengthOfLongestPalindromicSubStringM(inputString, start + 1, end - 1) + 2;
        }
        else
        {
            return System.Math.Max(
                GetLengthOfLongestPalindromicSubStringM(inputString, start + 1, end),
                GetLengthOfLongestPalindromicSubStringM(inputString, start, end - 1)
                );            
        }
    }
}