namespace algoexpert
{
// Group Anagrams

// Write a function that takes in an array of strings and returns a list of groups of anagrams.Anagrams are strings 
// made up of exactly the same letters, where order doesn't matter. For example, "cinema" and "iceman" are anagrams; 
// similarly, "foo" and "ofo" are anagrams. Note that the groups of anagrams don't need to be ordered in any 
// particular way.

// Sample input: ["yo", "act", "flop", "tac", "cat", "oy", "olfp"]
// Sample output: [["yo", "oy"], ["flop", "olfp"], ["act", "tac", "cat"]]

using System;
using System.Collections.Generic;

public partial class Program
    {
        // O(w * n * log(n)) time | O(wn) space - where w is the number of words and n is the length of the longest word
        public static List<List<string>> groupAnagrams(List<string> words)
        {
            Dictionary<string,
              List<string>> anagrams = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string sortedWord = new String(charArray);

                if (anagrams.ContainsKey(sortedWord))
                {
                    anagrams[sortedWord].Add(word);
                }
                else
                {
                    anagrams[sortedWord] = new List<string>(){
                    word
                };
                }
            }

            List<List<string>> output = new List<List<string>>();
            foreach (KeyValuePair<string, List<string>> entry in anagrams)
            {
                output.Add(entry.Value);
            }
            return output;
        }
    }
}