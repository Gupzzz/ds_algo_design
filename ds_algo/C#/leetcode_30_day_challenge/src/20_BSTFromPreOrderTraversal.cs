using System;
using System.Collections.Generic;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static TreeNode BSTFromPreOrderTraversal(int[] preorder, int bound)
        {
            if (i == preorder.Length || preorder[i] > bound) return null;
            TreeNode root = new TreeNode(preorder[i++]);
            root.left = BSTFromPreOrderTraversal(preorder, root.val);
            root.right = BSTFromPreOrderTraversal(preorder, bound);
            return root;
        }
        public static void _BSTFromPreOrderTraversal()
        {
            i = 0;
            int[] preorder = new int[] { 8, 5, 1, 7, 10, 12 };
            Console.WriteLine("Pre Order Traversal:");
            foreach (var item in preorder)
                Console.Write(item + "\t");
            TreeNode root = BSTFromPreOrderTraversal(preorder, Int32.MaxValue);

            Console.WriteLine("\nBinary Search Tree");
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                TreeNode node = queue.Dequeue();
                if (node == null)
                {
                    Console.Write("null\t");
                    continue;
                }
                Console.Write(node.val + "\t");
                if (node.left == null && node.right == null) continue;
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);

            }
        }
    }
}