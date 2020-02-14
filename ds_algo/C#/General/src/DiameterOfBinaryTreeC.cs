using System;

namespace general
{
    class A
    {
        public int ans = int.MinValue;
    }
    class DiameterOfBinaryTreeC
    {
        
        /* Computes the diameter of binary  
        tree with given root. */
        public int FindDiameterOfBinaryTree(NodeChar root)
        {
            if (root == null)
                return 0;

            // This will store the final answer  
            A a = new A();
            int height_of_tree = height(root, a);
            return a.ans;
        }

        /* Function to find height of a tree */
        public int height(NodeChar root, A a)
        {
            if (root == null)
                return 0;

            int left_height = height(root.left, a);

            int right_height = height(root.right, a);

            // update the answer, because diameter of a  
            // tree is nothing but maximum value of  
            // (left_height + right_height + 1) for each node  
            a.ans = Math.Max(a.ans, 1 + left_height +
                            right_height);

            return 1 + Math.Max(left_height, right_height);
        }
    }
}