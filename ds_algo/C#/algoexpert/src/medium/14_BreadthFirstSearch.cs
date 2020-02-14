namespace algoexpert
{
// Breadth-first Search

// You are given a Node class that has a name and an array of optional children Nodes.When put together, Nodes 
// form a simple tree-like structure. Implement the breadthFirstSearch method on the Node class, which takes in 
// an empty array, traverses the tree using the Breadth-first Search approach(specifically navigating the tree 
// from left to right), stores all of the Nodes' names in the input array, and returns it.

// Sample input:
//          A
//        / | \
//     B C  D
//    / \       / \
// E F  G H
//       / \    \
//      I J    K
// Sample output: ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K"]

using System.Collections.Generic;

public partial class Program
    {
        public class BFSNode
        {
            public string name;
            public List<BFSNode> children = new List<BFSNode>();

            public BFSNode(string name)
            {
                this.name = name;
            }

            // O(v + e) time | O(v) space
            public List<string> BreadthFirstSearch(List<string> array)
            {
                List<BFSNode> queue = new List<BFSNode>();
                queue.Add(this);
                var index = 0;
                while (index < queue.Count)
                {
                    BFSNode current = queue[index];
                    index += 1;
                    array.Add(current.name);
                    for (int i = 0; i < current.children.Count; i++)
                    {
                        queue.Add(current.children[i]);
                    }
                }
                return array;
            }

            public BFSNode AddChild(string name)
            {
                BFSNode child = new BFSNode(name);
                children.Add(child);
                return this;
            }
        }
    }
}