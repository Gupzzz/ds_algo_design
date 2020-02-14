using System;

namespace VScode
{
    public class WordBreakC
    {
        // https://www.geeksforgeeks.org/word-break-problem-using-backtracking/
        public bool dictionaryContains(string word)
        {
            string[] dictionary = {"mobile","samsung","sam","sung",
                            "man","mango", "icecream","and",
                            "go","i","love","ice","cream"};
            for (int i = 0; i < dictionary.Length; i++)
                if (string.Equals(dictionary[i], word))
                    return true;
            return false;
        }


        // Prints all possible word breaks of given string 
        public void wordBreak(string str)
        {
            // last argument is prefix 
            wordBreakUtil(str, str.Length, "");
        }

        // result store the current prefix with spaces 
        // between words 
        public void wordBreakUtil(string str, int n, string result)
        {
            //Process all prefixes one by one 
            for (int i = 1; i <= n; i++)
            {
                //extract substring from 0 to i in prefix 
                string prefix = str.Substring(0, i);

                // if dictionary conatins this prefix, then 
                // we check for remaining string. Otherwise 
                // we ignore this prefix (there is no else for 
                // this if) and try next 
                if (dictionaryContains(prefix))
                {
                    // if no more elements are there, print it 
                    if (i == n)
                    {
                        // add this element to previous prefix 
                        result += prefix;
                        Console.WriteLine(result);
                        return;
                    }
                    wordBreakUtil(str.Substring(i, n - i), n - i, result + prefix + " ");
                }
            }      //end for 
        }//end function
    }
}