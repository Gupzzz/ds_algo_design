namespace algoexpert
{
// Suffix Trie Construction

// Write a class for a suffix-trie-like data structure.The class should have a "root" property set to be the root 
// node of the trie.The class should support creation from a string and the searching of strings.The creation method 
// (called populateSuffixTrieFrom()) will be called when the class is instantiated and should populate the "root" 
// property of the class. Note that every string added to the trie should end with the special "endSymbol" 
// character: "*".

// Sample input(for creation): "babc"
// Sample output(for creation):
// {
//         "c": { "*": True},
//   "b": {
//             "c": { "*": True},
//     "a": { "b": { "c": { "*": True} } },
//   },
//   "a": { "b": { "c": { "*": True} } },
// }
//     Sample input(for searching in the suffix trie above): "abc"
// Sample output(for searching in the suffix trie above): True

using System.Collections.Generic;

public partial class Program
    {
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        }

        public class SuffixTrie
        {
            public TrieNode root = new TrieNode();
            public char endSymbol = '*';

            public SuffixTrie(string str)
            {
                PopulateSuffixTrieFrom(str);
            }

            // O(n^2) time | O(n^2) space
            public void PopulateSuffixTrieFrom(string str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    insertSubstringStartingAt(i, str);
                }
            }

            public void insertSubstringStartingAt(int i, string str)
            {
                TrieNode node = root;
                for (int j = i; j < str.Length; j++)
                {
                    char letter = str[j];
                    if (!node.Children.ContainsKey(letter))
                    {
                        TrieNode newNode = new TrieNode();
                        node.Children.Add(letter, newNode);
                    }
                    node = node.Children[letter];
                }
                node.Children[endSymbol] = null;
            }

            // O(m) time | O(1) space
            public bool Contains(string str)
            {
                TrieNode node = root;
                for (int i = 0; i < str.Length; i++)
                {
                    char letter = str[i];
                    if (!node.Children.ContainsKey(letter))
                    {
                        return false;
                    }
                    node = node.Children[letter];
                }
                return node.Children.ContainsKey(endSymbol) ? true : false;
            }
        }
    }
}