using System.Collections.Generic;

namespace algoexpert
{
    public class LinkedList
    {
        public int Value;
        public LinkedList Next = null;

        public LinkedList(int value)
        {
            this.Value = value;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    }
}