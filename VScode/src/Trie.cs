using System.Collections.Generic;

public class TrieNode
    {
        public char Value { get; set; }
        public List<TrieNode> Children { get; set; }
        // public Node Parent { get; set; }
        // public int Depth { get; set; }

        // public Node(char value, int depth, Node parent)
        public TrieNode(char value)
        {
            Value = value;
            Children = new List<TrieNode>();
            // Depth = depth;
            // Parent = parent;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public TrieNode FindChildNode(char c)
        {
            foreach (var child in Children)
                if (child.Value == c)
                    return child;

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for (var i = 0; i < Children.Count; i++)
                if (Children[i].Value == c)
                    Children.RemoveAt(i);
        }
    }