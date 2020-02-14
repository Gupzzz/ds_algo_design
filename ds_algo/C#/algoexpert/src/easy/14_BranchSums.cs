namespace algoexpert
{
// ​Branch Sums

// Write a function that takes in a Binary Tree and returns a list of its branch sums(ordered from leftmost branch 
// sum to rightmost branch sum). A branch sum is the sum of all values in a Binary Tree branch.A Binary Tree branch 
// is a path of nodes in a tree that starts at the root node and ends at any leaf node. Each Binary Tree node has 
// a value stored in a property called "value" and two children nodes stored in properties called "left" and "right," 
// respectively.Children nodes can either be Binary Tree nodes themselves or the None (null) value.

// Sample input:
//             1
//           /     \
//         2        3
//       /    \    /    \
//     4      5 6      7
//   /   \      \
// 8      9   10
// Sample output: [15, 16, 18, 10, 11]
using System.Collections.Generic;

public partial class Program
    {
        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }

        // O(n) time | O(n) space - where n is the number of nodes in the Binary Tree
        public static List<int> BranchSums(BinaryTree root)
        {
            List<int> sums = new List<int>();
            calculateBranchSums(root, 0, sums);
            return sums;
        }

        public static void calculateBranchSums(BinaryTree node, int runningSum, List<int> sums)
        {
            if (node == null) return;

            int newRunningSum = runningSum + node.value;
            if (node.left == null && node.right == null)
            {
                sums.Add(newRunningSum);
                return;
            }

            calculateBranchSums(node.left, newRunningSum, sums);
            calculateBranchSums(node.right, newRunningSum, sums);
        }
    }
}