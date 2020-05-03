using System;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static int BinaryTreeMaximumPathSum(TreeNode node){
            if (node == null) return 0;
            int left = Math.Max(0, BinaryTreeMaximumPathSum(node.left));
            int right = Math.Max(0, BinaryTreeMaximumPathSum(node.right));
            maxValue = Math.Max(maxValue, left + right + node.val);
            return Math.Max(left, right) + node.val;
        }
        public static void _BinaryTreeMaximumPathSum(){
            maxValue = Int32.MinValue;
            TreeNode root = new TreeNode(-10);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            BinaryTreeMaximumPathSum(root);
            Console.WriteLine("Maximum path sum is " + maxValue);
        }
    }
}