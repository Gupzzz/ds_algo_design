using System;
namespace VScode
{
    public class SubStringOccurranceInStringC
    {
        // Given two strings, find the number of times the second string
        //  occurs in the first string, whether continuous or discontinuous.
        public int SubStringOccurranceInString1(string completeString, string subString,
                                                 int m, int n)
        {
            // Console.WriteLine("m is {0} and n is {1}", m, n);
            if ((n == 0 && m == 0) || n == 0)
            {
                return 1;
            }
            if (m == 0)
            {
                return 0;
            }
            if (completeString[m - 1] == subString[n - 1])
            {
                return SubStringOccurranceInString1(completeString, subString, m-1, n-1) + 
                       SubStringOccurranceInString1(completeString, subString, m-1, n);
            }
            else
            {
                return SubStringOccurranceInString1(completeString, subString, m-1, n);
            }
        }
    }
}