namespace algoexpert
{
// Invert Binary Tree

// Write a function that takes in a Binary Tree and inverts it.In other words, the function should swap every 
// left node in the tree for its corresponding (mirrored) right node.Each Binary Tree node has a value stored 
// in a property called "value" and two children nodes stored in properties called "left" and "right," respectively.
// Children nodes can either be Binary Tree nodes themselves or the None (null) value.

// Sample input:
//             1
//           /     \
//         2        3
//       /    \    /    \
//     4      5 6      7
//   /   \
// 8      9
// Sample output:
//             1
//           /     \
//         3        2
//       /    \    /    \
//     7      6 5      4
//                          /   \
//                        9      8
public partial class Program
    {
        // O(n) time | O(d) space
        public static void InvertBinaryTree(InvertBinaryTreeClass tree)
        {
            if (tree == null)
            {
                return;
            }
            swapLeftAndRight(tree);
            InvertBinaryTree(tree.left);
            InvertBinaryTree(tree.right);
        }

        private static void swapLeftAndRight(InvertBinaryTreeClass tree)
        {
            InvertBinaryTreeClass left = tree.left;
            tree.left = tree.right;
            tree.right = left;
        }

        public class InvertBinaryTreeClass
        {
            public int value;
            public InvertBinaryTreeClass left;
            public InvertBinaryTreeClass right;

            public InvertBinaryTreeClass(int value)
            {
                this.value = value;
            }
        }
    }
}