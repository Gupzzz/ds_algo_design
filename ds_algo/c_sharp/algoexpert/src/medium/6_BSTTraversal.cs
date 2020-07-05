namespace algoexpert
{
// ​BST Traversal

// You are given a BST data structure consisting of BST nodes.Each BST node has an integer value stored in a 
// property called "value" and two children nodes stored in properties called "left" and "right," respectively.
// A node is said to be a BST node if and only if it satisfies the BST property: its value is strictly greater 
// than the values of every node to its left; its value is less than or equal to the values of every node to its 
// right; and both of its children nodes are either BST nodes themselves or None(null) values.Write three functions 
// that take in an empty array, traverse the BST, add its nodes' values to the input array, and return that array. 
// The three functions should traverse the BST using the in-order traversal, pre-order traversal, and post-order 
// traversal techniques, respectively.

// Sample input:
//             10
//           /       \
//         5         15
//       /    \            \
//     2      5           22
//   /
// 1
// Sample output(inOrderTraverse): [1, 2, 5, 5, 10, 15, 22]
//     Sample output(preOrderTraverse): [10, 5, 2, 1, 5, 15, 22]
//     Sample output(postOrderTraverse): [1, 2, 5, 5, 22, 15, 10]

using System.Collections.Generic;

public partial class Program
    {
        // O(n) time | O(n) space
        public static List<int> InOrderTraverse(BSTTraversal tree, List<int> array)
        {
            if (tree.left != null)
            {
                InOrderTraverse(tree.left, array);
            }
            array.Add(tree.value);
            if (tree.right != null)
            {
                InOrderTraverse(tree.right, array);
            }
            return array;
        }

        // O(n) time | O(n) space
        public static List<int> PreOrderTraverse(BSTTraversal tree, List<int> array)
        {
            array.Add(tree.value);
            if (tree.left != null)
            {
                PreOrderTraverse(tree.left, array);
            }
            if (tree.right != null)
            {
                PreOrderTraverse(tree.right, array);
            }
            return array;
        }

        // O(n) time | O(n) space
        public static List<int> PostOrderTraverse(BSTTraversal tree, List<int> array)
        {
            if (tree.left != null)
            {
                PostOrderTraverse(tree.left, array);
            }
            if (tree.right != null)
            {
                PostOrderTraverse(tree.right, array);
            }
            array.Add(tree.value);
            return array;
        }

        public class BSTTraversal
        {
            public int value;
            public BSTTraversal left;
            public BSTTraversal right;

            public BSTTraversal(int value)
            {
                this.value = value;
            }
        }
    }
}