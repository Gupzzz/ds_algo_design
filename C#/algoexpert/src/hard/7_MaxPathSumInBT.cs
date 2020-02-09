namespace algoexpert
{
    // Max Path Sum In Binary Tree

    // Write a function that takes in a Binary Tree and returns its max path sum. A path is a collection of connected nodes where no node is connected to 
    // more than two other nodes; a path sum is the sum of the values of the nodes in a particular path. Each Binary Tree node has a value stored in a 
    // property called "value" and two children nodes stored in properties called "left" and "right," respectively. Children nodes can either be Binary 
    // Tree nodes themselves or the None (null) value.

    // Sample input:
    //             1
    //           /     \
    //         2        3
    //       /    \    /     \
    //     4      5 6       7

    // Sample output: 18
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System;
    using System.Collections.Generic;

    public partial class Program
    {
        // O(n) time | O(log(n)) space
        public static int MaxPathSum(BinaryTree tree)
        {
            List<int> maxSumArray = findMaxSum(tree);
            return maxSumArray[1];
        }

        public static List<int> findMaxSum(BinaryTree tree)
        {
            if (tree == null)
            {
                return new List<int>(){
                       0, 0
            };
            }
            List<int> leftMaxSumArray = findMaxSum(tree.left);
            int leftMaxSumAsBranch = leftMaxSumArray[0];
            int leftMaxPathSum = leftMaxSumArray[1];

            List<int> rightMaxSumArray = findMaxSum(tree.right);
            int rightMaxSumAsBranch = rightMaxSumArray[0];
            int rightMaxPathSum = rightMaxSumArray[1];

            int maxChildSumAsBranch = Math.Max(leftMaxSumAsBranch, rightMaxSumAsBranch);
            int maxSumAsBranch = Math.Max(maxChildSumAsBranch + tree.value, tree.value);
            int maxSumAsRootNode = Math.Max(
                leftMaxSumAsBranch + tree.value + rightMaxSumAsBranch,
                maxSumAsBranch
                );
            int maxPathSum = Math.Max(leftMaxPathSum, Math.Max(rightMaxPathSum,
                maxSumAsRootNode));

            return new List<int>(){
                   maxSumAsBranch, maxPathSum
        };
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
    }
}