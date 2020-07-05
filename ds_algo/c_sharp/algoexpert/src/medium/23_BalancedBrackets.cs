namespace algoexpert
{

// Balanced Brackets

// Write a function that takes in a string made up of brackets("(", "[", "{", ")", "]", and "}") and other optional 
// characters.The function should return a boolean representing whether or not the string is balanced in regards to 
// brackets.A string is said to be balanced if it has as many opening brackets of a given type as it has closing 
// brackets of that type and if no bracket is unmatched.Note that a closing bracket cannot match a corresponding 
// opening bracket that comes after it.Similarly, brackets cannot overlap each other as in "[(])".


// Sample input: "([])(){}(())()()"
// Sample output: True (it is balanced)

using System.Collections.Generic;

public partial class Program
    {
        // O(n) time | O(n) space
        public static bool BalancedBrackets(string str)
        {
            string openingBrackets = "([{";
            string closingBrackets = ")]}";
            Dictionary<char, char> matchingBrackets = new Dictionary<char, char>();
            matchingBrackets.Add(')', '(');
            matchingBrackets.Add(']', '[');
            matchingBrackets.Add('}', '{');
            List<char> stack = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                if (openingBrackets.IndexOf(letter) != -1)
                {
                    stack.Add(letter);
                }
                else if (closingBrackets.IndexOf(letter) != -1)
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (stack[stack.Count - 1] == matchingBrackets[letter])
                    {
                        stack.RemoveAt(stack.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}