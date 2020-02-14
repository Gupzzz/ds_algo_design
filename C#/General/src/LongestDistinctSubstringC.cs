using System;

namespace VScode
{
    // https://www.geeksforgeeks.org/find-the-longest-substring-with-k-unique-characters-in-a-given-string/
    class LongestDistinctSubstringC
    {
        // Given a string you need to print longest possible substring that has exactly
        //  M unique characters. If there are more than one substring of longest possible
        //   length, then print any one of them.
        int MAX_CHARS = 26;

        // This function calculates number of unique characters 
        // using a associative array count[]. Returns true if 
        // no. of characters are less than required else returns 
        // false. 
        public bool isValid(int[] count, int k)
        {
            int val = 0;
            for (int i = 0; i < MAX_CHARS; i++)
            {
                if (count[i] > 0)
                {
                    val++;
                }
            }

            // Return true if k is greater than or equal to val 
            return (k >= val);
        }

        // Finds the maximum substring with exactly k unique chars 
        public void GetLongestPalindromicSubString(string s, int k)
        {
            int u = 0; // number of unique characters 
            int n = s.Length;

            // Associative array to store the count of characters 
            int[] count = new int[MAX_CHARS];
            Array.Fill(count, 0);
            // Traverse the string, Fills the associative array 
            // count[] and count number of unique characters 
            for (int i = 0; i < n; i++)
            {
                if (count[s[i] - 'a'] == 0)
                {
                    u++;
                }
                count[s[i] - 'a']++;
            }

            // If there are not enough unique characters, show 
            // an error message. 
            if (u < k)
            {
                Console.Write("Not enough unique characters");
                return;
            }

            // Otherwise take a window with first element in it. 
            // start and end variables. 
            int curr_start = 0, curr_end = 0;

            // Also initialize values for result longest window 
            int max_window_size = 1, max_window_start = 0;

            // Initialize associative array count[] with zero 
            Array.Fill(count, 0);

            count[s[0] - 'a']++;  // put the first character 

            // Start from the second character and add 
            // characters in window according to above 
            // explanation 
            for (int i = 1; i < n; i++)
            {
                // Add the character 's[i]' to current window 
                count[s[i] - 'a']++;
                curr_end++;

                // If there are more than k unique characters in 
                // current window, remove from left side 
                while (!isValid(count, k))
                {
                    count[s[curr_start] - 'a']--;
                    curr_start++;
                }

                // Update the max window size if required 
                if (curr_end - curr_start + 1 > max_window_size)
                {
                    max_window_size = curr_end - curr_start + 1;
                    max_window_start = curr_start;
                }
            }

            Console.Write("Max sustring is : "
                    + s.Substring(max_window_start, max_window_size)
                    + " with length " + max_window_size);
        }
    }
}