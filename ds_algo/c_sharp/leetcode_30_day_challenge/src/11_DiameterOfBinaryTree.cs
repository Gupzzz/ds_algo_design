using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        static int ans11;
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            Program.ans11 = 1;
            Program.Depth11(root);
            return Program.ans11 - 1;
        }
        public static int Depth11(TreeNode node)
        {
            if (node == null) return 0;
            int L = Program.Depth11(node.left);
            int R = Program.Depth11(node.right);
            Program.ans11 = Math.Max(Program.ans11, L + R + 1);
            return Math.Max(L, R) + 1;
        }
        public static void _DiameterOfBinaryTree()
        {
            TreeNode node = new TreeNode(1);
            TreeNode head = node;

            TreeNode leftNode = new TreeNode(2);
            TreeNode rightNode = new TreeNode(3);
            node.left = leftNode;
            node.right = rightNode;

            node = node.left;
            leftNode = new TreeNode(4);
            rightNode = new TreeNode(5);
            node.left = leftNode;
            node.right = rightNode;

            Console.WriteLine("The diameter of the tree is " + DiameterOfBinaryTree(head));
        }
    }
}