// ​Depth-first Search

// You are given a Node class that has a name and an array of optional children Nodes.
// When put together, Nodes form a simple tree-like structure. Implement the depthFirstSearch 
// method on the Node class, which takes in an empty array, traverses the tree using the 
// Depth-first Search approach(specifically navigating the tree from left to right), s
// tores all the of the Nodes' names in the input array, and returns it.

// Sample input:
//          A
//        / | \
//     B C  D
//    / \       / \
// E F  G H
//       / \    \
//      I J    K
// Sample output: ["A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H"]


using System.Collections.Generic;

namespace algoexpert
{
    public partial class Program
    {
        public class ThisNode
        {
            public string name;
            public List<ThisNode> children = new List<ThisNode>();

            public ThisNode(string name)
            {
                this.name = name;
            }

            // O(v + e) time | O(v) space
            public List<string> DepthFirstSearch(List<string> array)
            {
                array.Add(this.name);
                for (int i = 0; i < children.Count; i++)
                {
                    children[i].DepthFirstSearch(array);
                }
                return array;
            }

            public ThisNode AddChild(string name)
            {
                ThisNode child = new ThisNode(name);
                children.Add(child);
                return this;
            }
        }
    }
}