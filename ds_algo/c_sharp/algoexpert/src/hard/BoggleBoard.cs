namespace algoexpert
{
    using System;
    using System.Collections.Generic;

    public partial class Program
    {
        // O(nm*8^s + ws) time | O(nm + ws) space
        public static List<string> BoggleBoard(char[,] board, string[] words)
        {
            Trie trie = new Trie();
            foreach (string word in words)
            {
                trie.Add(word);
            }
            HashSet<string> finalWords = new HashSet<string>();
            bool[,] visited = new bool[board.GetLength(0), board.GetLength(1)];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    explore(i, j, board, trie.root, visited, finalWords);
                }
            }
            List<string> finalWordsArray = new List<string>();
            foreach (string key in finalWords)
            {
                finalWordsArray.Add(key);
            }
            return finalWordsArray;
        }

        public static void explore(int i, int j, char[,] board, BoggleBoardTrieNode BoggleBoardtrieNode, bool[,] visited,
          HashSet<string> finalWords)
        {
            if (visited[i, j])
            {
                return;
            }
            char letter = board[i, j];
            if (!BoggleBoardtrieNode.children.ContainsKey(letter))
            {
                return;
            }
            visited[i, j] = true;
            BoggleBoardtrieNode = BoggleBoardtrieNode.children[letter];
            if (BoggleBoardtrieNode.children.ContainsKey('*'))
            {
                finalWords.Add(BoggleBoardtrieNode.word);
            }
            List<int[]> neighbors = getNeighbors(i, j, board);
            foreach (int[] neighbor in neighbors)
            {
                explore(neighbor[0], neighbor[1], board, BoggleBoardtrieNode, visited, finalWords);
            }
            visited[i, j] = false;
        }

        public static List<int[]> getNeighbors(int i, int j, char[,] board)
        {
            List<int[]> neighbors = new List<int[]>();
            if (i > 0 && j > 0)
            {
                neighbors.Add(new int[] { i - 1, j - 1 });
            }
            if (i > 0 && j < board.GetLength(1) - 1)
            {
                neighbors.Add(new int[] { i - 1, j + 1 });
            }
            if (i < board.GetLength(0) - 1 && j < board.GetLength(1) - 1)
            {
                neighbors.Add(new int[] { i + 1, j + 1 });
            }
            if (i < board.GetLength(0) - 1 && j > 0)
            {
                neighbors.Add(new int[] { i + 1, j - 1 });
            }
            if (i > 0)
            {
                neighbors.Add(new int[] { i - 1, j });
            }
            if (i < board.GetLength(0) - 1)
            {
                neighbors.Add(new int[] { i + 1, j });
            }
            if (j > 0)
            {
                neighbors.Add(new int[] { i, j - 1 });
            }
            if (j < board.GetLength(1) - 1)
            {
                neighbors.Add(new int[] { i, j + 1 });
            }
            return neighbors;
        }

        public class BoggleBoardTrieNode
        {
            public Dictionary<char, BoggleBoardTrieNode> children = new Dictionary<char, BoggleBoardTrieNode>();
            public string word = "";
        }

        public class Trie
        {
            public BoggleBoardTrieNode root;
            public char endSymbol;

            public Trie()
            {
                this.root = new BoggleBoardTrieNode();
                this.endSymbol = '*';
            }

            public void Add(string str)
            {
                BoggleBoardTrieNode node = this.root;
                for (int i = 0; i < str.Length; i++)
                {
                    char letter = str[i];
                    if (!node.children.ContainsKey(letter))
                    {
                        BoggleBoardTrieNode newNode = new BoggleBoardTrieNode();
                        node.children.Add(letter, newNode);
                    }
                    node = node.children[letter];
                }
                node.children[this.endSymbol] = null;
                node.word = str;
            }
        }
    }
}

/*
Test Case 1
{
  "board": [
    ["t", "h", "i", "s", "i", "s", "a"],
    ["s", "i", "m", "p", "l", "e", "x"],
    ["b", "x", "x", "x", "x", "e", "b"],
    ["x", "o", "g", "g", "l", "x", "o"],
    ["x", "x", "x", "D", "T", "r", "a"],
    ["R", "E", "P", "E", "A", "d", "x"],
    ["x", "x", "x", "x", "x", "x", "x"],
    ["N", "O", "T", "R", "E", "-", "P"],
    ["x", "x", "D", "E", "T", "A", "E"]
  ],
  "words": [
    "this",
    "is",
    "not",
    "a",
    "simple",
    "boggle",
    "board",
    "test",
    "REPEATED",
    "NOTRE-PEATED"
  ]
}

return the words that are present in the board
*/
