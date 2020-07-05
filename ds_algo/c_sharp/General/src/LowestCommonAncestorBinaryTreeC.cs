using System.Collections.Generic;
using System;

namespace general
{
    class LowestCommonAncestorBinaryTreeC
    {
        public char FindLowestCommonAncestorBinaryTree(NodeChar root, char n1, char n2)
        {
            List<char> path1 = new List<char>();
            List<char> path2 = new List<char>();
            if(!findPath(root, n1, path1) || !findPath(root, n2, path2))
            {
                Console.WriteLine((path1.Count > 0) ? "n1 is present" : "n1 is missing");
                Console.WriteLine((path2.Count > 0) ? "n2 is present" : "n2 is missing");
                return '$';
            }

            int i;
            for (i = 0; i<path1.Count && i<path2.Count; i++)
            {
                // System.out.println(path1.get(i) + " " + path2.get(i)); 
                if (!path1[i].Equals(path2[i]))
                    break;
            }

            return path1[i - 1];
        }
        private bool findPath(NodeChar root, char n, List<char> path)
        {
            // base case 
            if (root == null)
            {
                return false;
            }

            // Store this node . The node will be removed if 
            // not in path from root to n. 
            path.Add(root.Value);

            if (root.Value == n)
            {
                return true;
            }

            if (root.left != null && findPath(root.left, n, path))
            {
                return true;
            }

            if (root.right != null && findPath(root.right, n, path))
            {
                return true;
            }

            // If not present in subtree rooted with root, remove root from 
            // path[] and return false 
            path.RemoveAt(path.Count - 1);

            return false;
        }
    }
}
