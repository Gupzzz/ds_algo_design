namespace algoexpert
{
// ​Palindrome Check

// Write a function that takes in a non-empty string and that returns a boolean representing 
// whether or not the string is a palindrome.A palindrome is defined as a string that is written 
// the same forward and backward.

// Sample input: "abcdcba"
// Sample output: True (it is a palindrome)
public partial class Program
    {
        // O(n) time | O(1) space
        public static bool IsPalindrome(string str)
        {
            int leftIdx = 0;
            int rightIdx = str.Length - 1;
            while (leftIdx < rightIdx)
            {
                if (str[leftIdx] != str[rightIdx])
                {
                    return false;
                }
                leftIdx++;
                rightIdx--;
            }
            return true;
        }
    }
}